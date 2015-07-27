using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;

namespace StneApiGenerator
{
    class Program
    {
        const string Url = "http://game3.stne.net/objectexplorer";
        const string LinkPrefix = "ObjectExplorer.aspx?p=";

        static void Main(string[] args)
        {
            //Download main list of elements (classes, enums, structs, ...)
            var data = new WebClient().DownloadString(Url);
            var doc = new HtmlDocument();
            doc.LoadHtml(data);

            //Convert the html list to an actual list
            var types = doc.DocumentNode.Descendants("a")
                .Select(node => node.Attributes.First(attribute => attribute.Name == "href").Value)
                .Where(link => link.StartsWith(LinkPrefix) && link.Length > LinkPrefix.Length)
                .Select(link => link.Substring(LinkPrefix.Length));
        }
    }
}
