using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using static StneApiGenerator.ElementType;

namespace StneApiGenerator
{
    class Program
    {
        const string ProjectUrl = "http://github.com/TheJP/Stne";
        const string Url = "http://game3.stne.net/";
        const string RegularSuffix = "objectexplorer";
        const string LinkSuffix = "ObjectExplorer.aspx?p=";
        const string OutputPath = "output";

        const string OutputNamespace = "StneApi";

        private WebClient WebClient { get; } = new WebClient();

        /// <summary>
        /// Downloads the type description from stne.net and saves it as C# type to the file system.
        /// </summary>
        /// <param name="name">type name</param>
        private void SaveType(string name)
        {
            Console.WriteLine($"Creating {name}");
            var type = TypeInformation.Load(name, WebClient.DownloadString($"{Url}{LinkSuffix}{name}"));
            var file = new FileInfo($"{OutputPath}\\{name}.cs");
            //Function to convert parameter list
            Func<List<TypeInformation.Element>, string> parametersToString = ps =>
                String.Join(", ", ps.Select(p => $"{p.Type ?? "object"} {p.Name}").ToArray());
            using (var streamWriter = new StreamWriter(file.Open(FileMode.CreateNew, FileAccess.Write, FileShare.None)))
            {
                var writer = new CodeWriter(streamWriter);
                //Namespace and header
                writer.WriteLine($"namespace {OutputNamespace}");
                writer.WriteLine("{");
                writer.IdentGrade = 1;
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// This is a type, which was automatically generated for the StneApi.");
                writer.WriteLine($"/// More Infos and the source code can be found here: {ProjectUrl}");
                writer.WriteLine("/// </summary>");
                //Class definition
                var typeString = type.Type.ToLower()
                    .Replace("enum", "class")
                    .Replace("structure", "struct");
                var inheritance = type.Inheritance == null ? "" : $" : {type.Inheritance}";
                writer.WriteLine($"{typeString} {type.TypeName}{inheritance}");
                writer.WriteLine("{");
                writer.IdentGrade = 2;
                //Attributes
                foreach(var attribute in type.Elements.Where(e => e.ElementType == Variable))
                {
                    writer.WriteLine($"public {(attribute.Static ? "static " : "")}{attribute.Type ?? "object"} {attribute.Name};");
                }
                //Properties
                foreach (var property in type.Elements.Where(e => e.ElementType == Property))
                {
                    writer.WriteLine($"public {(property.Static ? "static " : "")}{property.Type ?? "object"} {property.Name} {{ get; set; }}");
                }
                //Indexers
                foreach (var indexer in type.Elements.Where(e => e.ElementType == Indexer))
                {
                    writer.WriteLine($"public {indexer.Type} this[{parametersToString(indexer.ParameterList)}] {{ get; set; }}");
                }
                //Methods
                foreach (var method in type.Elements.Where(e => e.ElementType == Method))
                {
                    writer.WriteLine($"public {(method.Static ? "static " : "")}{method.Type ?? "void"} {method.Name}({parametersToString(method.ParameterList)}) {{ {(method.Type == null ? "" : "return null; ")}}}");
                }
                //Constructors
                foreach (var constructor in type.Elements.Where(e => e.ElementType == Constructor))
                {
                    writer.WriteLine($"public {type.TypeName}({parametersToString(constructor.ParameterList)}) {{ }}");
                }
                writer.IdentGrade = 1;
                writer.WriteLine("}");
                writer.IdentGrade = 0;
                writer.WriteLine("}");
                writer.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();

            //Download main list of elements (classes, enums, structs, ...)
            var data = program.WebClient.DownloadString($"{Url}{RegularSuffix}");
            var doc = new HtmlDocument();
            doc.LoadHtml(data);

            //Convert the html list to an actual list
            var types = doc.DocumentNode.Descendants("a")
                .Select(node => node.Attributes.First(attribute => attribute.Name == "href").Value)
                .Where(link => link.StartsWith(LinkSuffix) && link.Length > LinkSuffix.Length)
                .Select(link => link.Substring(LinkSuffix.Length))
                .Distinct();

            //Create directory to save generated api in it
            if (Directory.Exists(OutputPath))
            {
                Directory.Delete(OutputPath, true);
            }
            Directory.CreateDirectory(OutputPath);

            //Save each type in a separate file
            foreach(var type in types)
            {
                program.SaveType(type);
            }
        }
    }
}
