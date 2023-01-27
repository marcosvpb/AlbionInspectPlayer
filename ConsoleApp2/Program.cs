using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var url = @"https://albiononline.com/pt/killboard/search?q=gdsl";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            //  htmlDoc = web.Load(html);
            Console.WriteLine(doc.Text);
            var nodes = doc.DocumentNode.SelectSingleNode("//ul[@class='search-result']");
            if (nodes == null)
            {
                Console.WriteLine("NULL PORRA");
                Console.Read();
            }
            Console.WriteLine(nodes.ChildNodes.Count);
            /*var categories = nodes.SelectNodes("li");
            foreach (var category in categories)
            {
                var anchor = category.SelectSingleNode("a");
                string shoeCategory = anchor.InnerText.Trim();
                Console.WriteLine(shoeCategory);
            }

            */
            Console.Read();
        }
    }
}
