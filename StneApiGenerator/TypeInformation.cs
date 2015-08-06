using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static StneApiGenerator.ElementType;

namespace StneApiGenerator
{
    enum ElementType { Parameter, Variable, Property, Indexer, Method, Constructor }
    /// <summary>
    /// Represents a Type. It includes logic to convert stne html to type information.
    /// </summary>
    class TypeInformation
    {
        public string TypeName { get; }
        public string Type { get; private set; }
        public List<Element> Elements { get; private set; } = new List<Element>();
        public string Inheritance { get; private set; }

        private static readonly Regex ParameterRegex = new Regex("([a-zA-Z]+[a-zA-Z0-9]*) As", RegexOptions.CultureInvariant);
        private static readonly Regex StripEncodings = new Regex("&[a-zA-Z0-9]+;", RegexOptions.CultureInvariant);

        private TypeInformation(string name)
        {
            TypeName = name;
            Elements = new List<Element>();
        }

        public static TypeInformation Load(string name, string html)
        {
            html = StripEncodings.Replace(html, "");
            var result = new TypeInformation(name);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            //Initialize cursor (position marker inside the html)
            var cursor = doc.DocumentNode.Descendants("hr").First().NextSibling;
            result.Type = cursor.InnerText.Trim();

            //Inheritance
            cursor = cursor.NextSibling.NextSibling;
            if (cursor.InnerText.Trim() == ":")
            {
                result.Inheritance = cursor.NextSibling.InnerText.Trim();
                cursor = cursor.NextSibling.NextSibling;
            }
            cursor = cursor.NextSibling; //Set cursor to first element

            //Get type elements
            while (cursor.Name != "hr")
            {
                var element = new Element();
                var keywords = cursor.InnerText.Trim().Split(' ');
                element.Static = keywords[0] == "Static";
                element.ElementType = StringToElementType(keywords.Last(), cursor);

                //Read name of non constructor elements
                if(element.ElementType != Constructor)
                {
                    cursor = cursor.NextSibling;
                    element.Name = cursor.InnerText.Trim();
                }

                //Read parameter list of methods, constructors and indexers
                if (element.ElementType == Method ||
                    element.ElementType == Constructor ||
                    element.ElementType == Indexer)
                {
                    element.ParameterList = new List<Element>();
                    cursor = cursor.NextSibling;
                    while (!cursor.InnerText.Trim().EndsWith(") As") &&
                        !cursor.InnerText.Contains("()") &&
                        cursor.InnerText.Trim() != ")" &&
                        cursor.InnerText.Trim() != "As")
                    {
                        var parameter = new Element();
                        parameter.ElementType = Parameter;
                        parameter.Name = ParameterRegex.Match(cursor.InnerText).Groups[1].Value;
                        cursor = cursor.NextSibling;
                        parameter.Type = cursor.InnerText.Trim();
                        cursor = cursor.NextSibling;
                        element.ParameterList.Add(parameter);
                    }
                }
                else
                {
                    cursor = cursor.NextSibling;
                }

                var hasType = cursor.InnerText.Contains("As");
                if (hasType)
                {
                    cursor = cursor.NextSibling;
                    element.Type = cursor.InnerText.Trim();
                    cursor = cursor.NextSibling;
                }

                cursor = cursor.NextSibling;
                var add = cursor.InnerText.Trim() != "(geerbt)";
                if (add)
                {
                    result.Elements.Add(element);
                    if (!hasType &&
                        element.ElementType != Property &&
                        element.ElementType != Variable)
                    {
                        cursor = cursor.NextSibling;
                    }
                }
                else
                {
                    cursor = cursor.NextSibling.NextSibling;
                }
            }

            return result;
        }

        /// <summary>
        /// Converts a type string to the correct enum value.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static ElementType StringToElementType(string type, HtmlNode cursor)
        {
            switch (type)
            {
                case "New": return Constructor;
                case "Function": return Method;
                case "Property":
                    //Perform look-ahead to check, if it is an indexer
                    if (cursor.NextSibling.NextSibling.InnerText.Contains("("))
                    {
                        return Indexer;
                    }
                    return Property;
                case "Var": return Variable;
                default: throw new ArgumentException($"'{nameof(type)}' is invalid");
            }
        }

        /// <summary>
        /// Member of the element list in a TypeInformation.
        /// </summary>
        public class Element
        {
            public bool Static { get; set; }
            public ElementType ElementType { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            /// <summary>
            /// Optional parameter list. Only available for ElementType Method and Constructor.
            /// </summary>
            public List<Element> ParameterList { get; set; }
        }

        /// <summary>
        /// Implement comparer for Elements, using its Name Property.
        /// </summary>
        private class ElementComparer : IEqualityComparer<Element>
        {
            public bool Equals(Element x, Element y) => x.Name == y.Name;
            public int GetHashCode(Element obj) => obj.Name?.GetHashCode() ?? 0;
        }
    }
}
