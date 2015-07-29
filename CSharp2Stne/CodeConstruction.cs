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
using static CSharp2Stne.Program;

namespace CSharp2Stne
{
    class CodeConstruction
    {
        const int IdentSize = 4;
        private string mainClass = null;
        private TextWriter writer;
        private string ident = "";
        public int Ident
        {
            get { return ident.Length; }
            set { ident = new string(' ', value * IdentSize); }
        }

        public CodeConstruction(TextWriter writer)
        {
            this.writer = writer;
        }

        public void RecursiveConstruction(IEnumerable<SyntaxNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (node is NamespaceDeclarationSyntax)
                {
                    Console.WriteLine("Warning: Namespaces are not supported in stne scripts and will therefor be ignored.");
                }
                if (node is ClassDeclarationSyntax) { ConstructClass(node as ClassDeclarationSyntax); }
                else
                {
                    //Console.WriteLine($"{new string(' ', ident*4)} {node.GetType()}");
                    RecursiveConstruction(node.ChildNodes());
                }
            }
        }

        private void ConstructClass(ClassDeclarationSyntax declaration)
        {
            Func<BaseTypeSyntax, string> getTypeString = (type => (type.Type as IdentifierNameSyntax)?.Identifier)?.Text);
            //Check if type is entry point
            if (declaration.BaseList.Types.Any(
                type => (getTypeString(type) == StneProgramClass))
            {
                if (mainClass == null) { mainClass = declaration.Identifier.Text; }
                else
                {
                    Console.WriteLine($"Error: Found multiple entry points for program. Only one class is allowed to extend {StneProgramClass}.");
                    Environment.Exit(0);
                }
            }
            var baseString = declaration.BaseList.Types.Select(type => type.Type)
            WriteCode($"Class {declaration.Identifier}{}");
            WriteCode("{");
            ++Ident;
            RecursiveConstruction(declaration.ChildNodes());
            --Ident;
            WriteCode("}");
        }

        private void WriteCode(string line)
        {
            writer.WriteLine($"{ident}{line}");
        }
    }
}
