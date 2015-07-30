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
        private TextWriter Writer { get; set; }
        private SemanticModel Model { get; set; }
        private string ident = "";
        private int Ident
        {
            get { return ident.Length / IdentSize; }
            set { ident = new string(' ', value * IdentSize); }
        }
        private String CurrentType { get; set; } = null;

        public CodeConstruction(TextWriter writer, SemanticModel model)
        {
            this.Writer = writer;
            this.Model = model;
        }

        /// <summary>
        /// Creates the Code and writes it to the given writer.
        /// </summary>
        /// <param name="nodes">Root node of the syntax to create the code from.</param>
        public void ConstructCode(IEnumerable<SyntaxNode> nodes)
        {
            RecursiveConstruction(nodes);
            if (!String.IsNullOrWhiteSpace(mainClass))
            {
                //Call bootstrap method
                WriteCode($"Var main As New {mainClass}();");
                WriteCode("main.Main();");
            }
            else
            {
                Warn("Found no entry point to the application. " +
                    "If you don't intend to create a library, you should add a class, which derives from StneProgram.");
            }
        }

        private void RecursiveConstruction(IEnumerable<SyntaxNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (node is NamespaceDeclarationSyntax)
                {
                    Warn("Namespaces are not supported in stne scripts and will therefor be ignored.", node);
                }
                if (node is ClassDeclarationSyntax) { ConstructClass(node as ClassDeclarationSyntax); }
                else if (node is MethodDeclarationSyntax) { ConstructMethod(node as MethodDeclarationSyntax); }
                else if (node is ExpressionStatementSyntax) { ConstructStatement(node as ExpressionStatementSyntax); }
                else if (node is ReturnStatementSyntax) { ConstructStatement(node as ReturnStatementSyntax, true); }
                else if (node is BreakStatementSyntax) { Error("Break statements are not supported.", node); }
                else if (node is ArrowExpressionClauseSyntax) { Error("Lambda expressions are not supported", node); }
                else if (node is ThisExpressionSyntax) { WriteExpression("This"); }
                else if (node is LiteralExpressionSyntax) { WriteExpression(node.ToString()); }
                else if (node is InvocationExpressionSyntax) { ConstructInvocation(node as InvocationExpressionSyntax); }
                else
                {
                    //Console.WriteLine($"{new string(' ', ident*4)} {node.GetType()}");
                    RecursiveConstruction(node.ChildNodes());
                }
            }
        }

        private void ConstructStatement(StatementSyntax expression, bool isReturn = false)
        {
            Writer.Write(ident);
            if (isReturn) { WriteExpression("Return "); }
            RecursiveConstruction(expression.ChildNodes());
            Writer.WriteLine(";");
        }

        private void ConstructInvocation(InvocationExpressionSyntax expression)
        {
            var info = Model.GetSymbolInfo(expression.Expression);
            if (info.Symbol.ContainingType != null && CurrentType != null && info.Symbol.ContainingType.Name == CurrentType)
            {
                WriteExpression("This.");
            }
            WriteExpression($"{expression.Expression}(");
            RecursiveConstruction(expression.ChildNodes());
            WriteExpression(")");
        }

        private void ConstructMethod(MethodDeclarationSyntax declaration)
        {
            if(declaration.ParameterList.Parameters.Any(p => p.Default != null))
            {
                Error("Optional parameters are not supported in stne scripts.", declaration);
            }
            if (declaration.TypeParameterList != null && declaration.TypeParameterList.Parameters.Any())
            {
                Error("Generics are not supported in stne scripts.", declaration);
            }
            var parameterList = String.Join(", ", declaration.ParameterList.Parameters
                .Select(parameter => $"{parameter.Identifier} As {parameter.Type}")
                .ToArray());
            var isVoid = ((declaration.ReturnType as PredefinedTypeSyntax)?.Keyword)?.Text == "void";
            var typeDefinition = isVoid ? "" : $" As {declaration.ReturnType}";
            WriteCode();
            WriteCode($"Function {declaration.Identifier}({parameterList}){typeDefinition}");
            WriteCode("{");
            ++Ident;
            RecursiveConstruction(declaration.ChildNodes());
            --Ident;
            WriteCode("}");
        }

        private void ConstructClass(ClassDeclarationSyntax declaration)
        {
            Func<BaseTypeSyntax, string> getTypeString = type => ((type.Type as IdentifierNameSyntax)?.Identifier)?.Text;
            //Check if type is entry point
            if (declaration.BaseList.Types.Any(type => getTypeString(type) == StneProgramClass))
            {
                if (mainClass == null) { mainClass = declaration.Identifier.Text; }
                else { Error($"Found multiple entry points for program. Only one class is allowed to extend {StneProgramClass}.", declaration); }
            }
            //Generate inheritance list
            var inheritanceString = String.Join(", ", declaration.BaseList.Types
                .Select(getTypeString)
                .Where(type => type != null && type != StneProgramClass)
                .ToArray());
            //Write class declaration
            WriteCode($"Class {declaration.Identifier}" +
                (String.IsNullOrWhiteSpace(inheritanceString) ? "" : $" : {inheritanceString}"));
            WriteCode("{");
            CurrentType = declaration.Identifier.ToString();
            ++Ident;
            RecursiveConstruction(declaration.ChildNodes());
            --Ident;
            CurrentType = null;
            WriteCode("}");
        }

        private void WriteExpression(string expression)
        {
            Writer.Write(expression);
        }

        private void WriteCode(string line = "")
        {
            Writer.WriteLine($"{(String.IsNullOrWhiteSpace(line) ? "" : ident)}{line}");
        }

        private void Log(string prefix, string text, SyntaxNode node = null)
        {
            var position = node?.Span == null ? "" : $"({node?.Span.Start}-{node?.Span.End}) ";
            Console.WriteLine($"{prefix}: {position}{text}");
        }

        private void Warn(string text, SyntaxNode node = null)
        {
            Log("Warning", text, node);
        }

        private void Error(string text, SyntaxNode node = null)
        {
            Log("Error", text, node);
            Environment.Exit(0);
        }
    }
}
