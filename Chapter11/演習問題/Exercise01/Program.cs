using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }




        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name").Value,
                Teammembers = (string)x.Element("teammembers").Value,
            });
            foreach (var Xelement in sports) {
                Console.WriteLine("{0} {1}", Xelement.Name, Xelement.Teammembers);
            }


        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sort = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Attribute("kanji").Value,
                Firstplayed = x.Element("firstplayed").Value,
            }).OrderBy(x => x.Firstplayed);
            foreach (var sorts in sort) {
                Console.WriteLine("{0}({1})", sorts.Name, sorts.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var max = xdoc.Root.Elements().OrderByDescending(x => x.Element("teammembers").Value).First();
            Console.WriteLine($"{max.Element("name").Value}");
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863"));

            var xdoc = XDocument.Load("Sample.xml");
            xdoc.Root.Add(element);

            //確認用コード 
            foreach (var newsports in xdoc.Root.Elements()) {
                var xname = newsports.Element("name");
                var xteammembers = newsports.Element("teammembers");

                Console.WriteLine("{0} {1}", xname.Value, xteammembers.Value);
            }

            xdoc.Save("newsports.xml");
        }
    }
}