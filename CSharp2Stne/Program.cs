using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;

namespace CSharp2Stne
{
    class Program
    {
        public const string DefaultTargetName = "out.stne";
        public const string StneProgramClass = "StneProgram";

        /// <summary>
        /// Compile the c#-source to stne script using roslyn.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        private void Compile(FileInfo source, FileInfo target)
        {
            //Read File
            string sourceCode;
            using(var reader = new StreamReader(source.Open(FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                sourceCode = reader.ReadToEnd();
            }

            //Create roslyn objects
            var tree = CSharpSyntaxTree.ParseText(sourceCode);
            var root = (CompilationUnitSyntax)tree.GetRoot();
            var compilation = CSharpCompilation.Create("StneCompilation")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddReferences(MetadataReference.CreateFromFile(typeof(StneApi.Object).Assembly.Location))
                .AddSyntaxTrees(tree);
            var model = compilation.GetSemanticModel(tree);
            var nameInfo = model.GetSymbolInfo(root.Usings[0].Name);
            var systemSymbol = (INamespaceSymbol)nameInfo.Symbol;

            //Create script code
            using (var writer = new StreamWriter(target.Open(FileMode.Create, FileAccess.Write, FileShare.None)))
            {
                var code = new CodeConstruction(Console.Out);
                code.RecursiveConstruction(root.Members);
            }
        }

        static void Main(string[] args)
        {
            //Check command line arguments
            if(args.Length < 1 || args.Length > 2 || !File.Exists(args[0]))
            {
                var name = System.AppDomain.CurrentDomain.FriendlyName;
                Console.Error.WriteLine($"Usage: {name} <source-file-path> [<target-file-path>]");
                Environment.Exit(0);
            }

            //Start compilation
            var source = new FileInfo(args[0]);
            var target = new FileInfo(args.Length > 1 ? args[1] : DefaultTargetName);
            new Program().Compile(source, target);
        }
    }
}
