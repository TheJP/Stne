using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.IO;

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

        private void SaveType(string name)
        {
            var file = new FileInfo($"{name}.cs");
            using (var streamWriter = new StreamWriter(file.Open(FileMode.CreateNew, FileAccess.Write, FileShare.None)))
            {
                var writer = new CodeWriter(streamWriter);
                writer.WriteLine();
                writer.WriteLine($"namespace {OutputNamespace}");
                writer.WriteLine("{");
                writer.IdentGrade = 1;
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// This is a type, which was automatically generated for the StneApi.");
                writer.WriteLine($"/// More Infos and the source code can be found here: {ProjectUrl}");
                writer.WriteLine("/// </summary>");
                writer.WriteLine("");
                writer.IdentGrade = 0;
                writer.WriteLine("}");
                writer.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();

            //Download main list of elements (classes, enums, structs, ...)
            var data = new WebClient().DownloadString($"{Url}{RegularSuffix}");
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

        /// <summary>
        /// Makes the code generation easier.
        /// </summary>
        private class CodeWriter
        {
            const int IdentSize = 4;
            private string ident = "";

            public StreamWriter Writer { get; }
            public int IdentGrade
            {
                get { return ident.Length / IdentSize; }
                set { ident = Ident(value); }
            }

            private string Ident(int grade) => new string(' ', IdentSize * grade);

            public CodeWriter(StreamWriter writer)
            {
                Writer = writer;
            }

            public void Write(string content) => Writer.Write(content);
            public void WriteLine() => Writer.WriteLine();
            public void WriteLine(string line)
            {
                Writer.WriteLine($"{ident}{line}");
            }
        }
    }
}
