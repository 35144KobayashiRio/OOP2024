using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var xdoc = XDocument.Load("novelists.xml");
            var Xelements = xdoc.Root.Descendants("title");



            //foreach (var xnovelist in Xelements) {
            //    var xname = xnovelist.Element("name");             //要素の取得
            //    var xworks = xnovelist.Element("masterpieces")
            //        .Elements("title").Select(x => x.Value);              //属性の取得
            //    Console.WriteLine("{0}-{1}", xname.Value, string.Join(",", xworks));
            //    //Console.WriteLine($"{xname.Value} 【{xkana?.Value}】{birth.ToShortDateString()}");

            }
        }
    }
}
