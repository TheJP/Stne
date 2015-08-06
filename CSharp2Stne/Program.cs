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
        public static readonly string[] StneProgramClasses = { "StneProgram", "StneWebProgram", "StneShipPortal", "StneColonyPortal" };

        /// <summary>
        /// Compile the c#-source to stne script using roslyn.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        private void Compile(FileInfo source, FileInfo target, bool showWarnings)
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

            //Create script code
            using (var writer = new StreamWriter(target.Open(FileMode.Create, FileAccess.Write, FileShare.None)))
            {
                var code = new CodeConstruction(Console.Out, model, showWarnings);
                code.ConstructCode(root.Members);
            }
        }

        static void StopWithUsage()
        {
            var name = System.AppDomain.CurrentDomain.FriendlyName;
            Console.Error.WriteLine($"Usage: {name} [options] <source-file-path> [<target-file-path>]");
            Console.Error.WriteLine("Options");
            Console.Error.WriteLine("=======");
            Console.Error.WriteLine("--no-warnings\tHide warnings");
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            //Check command line arguments
            if(args.Length < 1 || args.Length > 3)
            {
                StopWithUsage();
            }

            //Start compilation
            var arg = 0;
            while (args[arg].StartsWith("--")) { ++arg; }
            if (arg >= args.Length || !File.Exists(args[arg]))
            {
                StopWithUsage();
            }
            var source = new FileInfo(args[arg++]);
            var target = new FileInfo(arg < args.Length ? args[arg++] : DefaultTargetName);
            new Program().Compile(source, target, !args.Contains("--no-warnings"));
        }
    }
}
