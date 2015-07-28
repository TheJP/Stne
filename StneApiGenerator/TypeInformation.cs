using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StneApiGenerator
{
    enum ElementType { Variable, Property, Method, Constructor }
    /// <summary>
    /// Represents a Type. It includes logic to convert stne html to type information.
    /// </summary>
    class TypeInformation
    {
        public string TypeName { get; }
        public string Type { get; private set; }
        public List<Element> Elements { get; }
        public string Inheritance { get; private set; } = "";

        private TypeInformation(string name)
        {
            TypeName = name;
            Elements = new List<Element>();
        }

        public static TypeInformation Load(string name, string html)
        {
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
            //while(cursor.Name != "hr")
            //{

            //}

            return result;
        }

        /// <summary>
        /// Member of the element list in a TypeInformation.
        /// </summary>
        public class Element
        {
            public bool Static { get; }
            public ElementType ElementType { get; }
            public string Name { get; }
            public string Type { get; }
            /// <summary>
            /// Optional parameter list. Only available for ElementType Method and Constructor.
            /// </summary>
            public List<Element> ParameterList { get; }
        }
    }
}
