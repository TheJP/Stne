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
        private Dictionary<string, string> castConversions = new Dictionary<string, string>()
        {
            ["String"] = "CStr",
            ["Byte"] = "CByte",
            ["Short"] = "CShort",
            ["Integer"] = "CInt",
            ["Long"] = "CLng",
            ["Double"] = "CDbl",
            ["Boolean"] = "CBool"
        };
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
            //Estimate user interface
            var basetype = nodes.Where(node => node is BaseTypeSyntax).FirstOrDefault() as BaseTypeSyntax;
            var basename = ((basetype?.Type as IdentifierNameSyntax)?.Identifier)?.Text;
            if (basename == "StneWebProgram") { WriteCode("#UseInterface Web;"); }
            else if (basename == "StneShipPortal") { WriteCode("#UseInterface Web, ShipPortal;"); }
            else if (basename == "StneColonyPortal") { WriteCode("#UseInterface Web, ColonyPortal;"); }
            //Construct code
            RecursiveConstruction(nodes);
            //Call bootstrap method
            if (!String.IsNullOrWhiteSpace(mainClass))
            {
                WriteCode($"Var main As New {mainClass}();");
                WriteCode("main.Main();");
            }
            else
            {
                Warn("Found no entry point to the application. " +
                    "If you don't intend to create a library, you should add a class, which derives from StneProgram.");
            }
        }

        private void RecursiveConstruction(SyntaxNode node)
        {
            RecursiveConstruction(new SyntaxNode[] { node });
        }

        private void RecursiveConstruction(IEnumerable<SyntaxNode> nodes)
        {
            if(nodes == null) { return; }
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
                else if (node is VariableDeclarationSyntax) { ConstructVariable(node as VariableDeclarationSyntax); }
                else if (node is BreakStatementSyntax) { Error("Break statements are not supported.", node); }
                else if (node is ArrowExpressionClauseSyntax) { Error("Lambda expressions are not supported", node); }
                else if (node is TypeParameterSyntax) { Error("Generics are not supported", node); }
                else if (node is ThisExpressionSyntax) { Write("This"); }
                else if (node is MemberAccessExpressionSyntax) { ConstructMemberAccess(node as MemberAccessExpressionSyntax); }
                else if (node is ObjectCreationExpressionSyntax) { ConstructNewExpression(node as ObjectCreationExpressionSyntax); }
                else if (node is ArgumentListSyntax) { ConstructArgumentList(node as ArgumentListSyntax); }
                else if (node is CastExpressionSyntax) { ConstructExplicitCast(node as CastExpressionSyntax); }
                else if (node is IdentifierNameSyntax) { Write((node as IdentifierNameSyntax).Identifier.ToString()); }
                else if (node is LiteralExpressionSyntax) { Write(node.ToFullString().Replace("true", "True").Replace("false", "False")); }
                else if (node is InvocationExpressionSyntax) { ConstructInvocation(node as InvocationExpressionSyntax); }
                else if (node is BinaryExpressionSyntax) { ConstructBinaryExpression(node as BinaryExpressionSyntax); }
                else { RecursiveConstruction(node.ChildNodes()); }
            }
        }

        private void ConstructExplicitCast(CastExpressionSyntax expression)
        {
            var castType = expression.Type.ToString().Trim();
            if (!castConversions.ContainsKey(castType))
            {
                Warn("Explicit casting is only possible for the following base types: " +
                    String.Join(", ", castConversions.Keys.ToArray()));
                RecursiveConstruction(expression.Expression);
            }
            else
            {
                Write(expression.GetLeadingTrivia().ToFullString());
                Write(castConversions[castType]);
                Write("(");
                RecursiveConstruction(expression.Expression);
                Write(")");
            }
        }

        private void ConstructArgumentList(ArgumentListSyntax list)
        {
            Write("(");
            int commas = list.Arguments.SeparatorCount;
            foreach(var argument in list.Arguments)
            {
                RecursiveConstruction(argument);
                if (--commas >= 0) { Write(", "); }
            }
            Write(")");
        }

        private void ConstructNewExpression(ObjectCreationExpressionSyntax expression)
        {
            Write("New ");
            Write(expression.Type.ToString());
            RecursiveConstruction(expression.ArgumentList);
        }

        private void ConstructMemberAccess(MemberAccessExpressionSyntax expression)
        {
            RecursiveConstruction(expression.Expression);
            Write(expression.OperatorToken.ToString());
            Write(expression.Name.ToString());
        }

        private void ConstructBinaryExpression(BinaryExpressionSyntax expression)
        {
            RecursiveConstruction(expression.Left);
            Write(expression.OperatorToken.ToFullString());
            RecursiveConstruction(expression.Right);
        }

        private void ConstructStatement(StatementSyntax expression, bool isReturn = false)
        {
            Writer.Write(ident);
            if (isReturn) { Write("Return "); }
            RecursiveConstruction(expression.ChildNodes());
            Writer.WriteLine(";");
        }

        private void ConstructInvocation(InvocationExpressionSyntax expression)
        {
            if (!(expression.Expression is MemberAccessExpressionSyntax))
            {
                var info = Model.GetSymbolInfo(expression.Expression);
                if (info.Symbol.ContainingType != null &&
                    CurrentType != null &&
                    info.Symbol.ContainingType.Name == CurrentType)
                {
                    //Special case, because stne can't access members of the same type without "This." prefix.
                    Write("This.");
                }
            }
            Write($"{expression.Expression}(".Replace("this.", "This."));
            RecursiveConstruction(expression.ArgumentList?.Arguments);
            Write(")");
        }

        private void ConstructVariable(VariableDeclarationSyntax declaration)
        {
            var type = declaration.Type.ToString();
            foreach (var variable in declaration.Variables)
            {
                if (declaration.Type.IsVar)
                {
                    type = Model.GetTypeInfo(variable.Initializer.Value).Type.Name;
                }
                Write(ident);
                Write($"Var {variable.Identifier} As {type}");
                if(variable.Initializer != null)
                {
                    Write(" = ");
                    RecursiveConstruction(variable.Initializer);
                }
                Writer.WriteLine(";");
            }
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
            if (declaration.BaseList.Types.Any(type => StneProgramClasses.Contains(getTypeString(type))))
            {
                if (mainClass == null) { mainClass = declaration.Identifier.Text; }
                else { Error("Found multiple entry points for program. " +
                    $"Only one class is allowed to extend one of the following classes: {String.Join(", ", StneProgramClasses)}.", declaration); }
            }
            //Generate inheritance list
            var inheritanceString = String.Join(", ", declaration.BaseList.Types
                .Select(getTypeString)
                .Where(type => type != null && !StneProgramClasses.Contains(type))
                .ToArray());
            if (!String.IsNullOrWhiteSpace(inheritanceString)) { Error("Inheritance is not supported.", declaration); }
            //Write class declaration
            WriteCode($"Class {declaration.Identifier}" +
                (String.IsNullOrWhiteSpace(inheritanceString) ? "" : $" : {inheritanceString}"));
            WriteCode("{");
            CurrentType = declaration.Identifier.ToString();
            ++Ident;
            RecursiveConstruction(declaration.Members);
            --Ident;
            CurrentType = null;
            WriteCode("}");
        }

        private void Write(string expression)
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
