using System;
using System.Collections.Generic;
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
            var sports = xdoc.Root.Elements()
                             .Select(x => new { Name = x.Element("name").Value,
                                                Teammembers = x.Element("teammembers").Value });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}人", sport.Name, sport.Teammembers);
            }
        }
        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {Firstplayed = x.Element("firstplayed").Value,
                                               Name = x.Element("name").Attribute("kanji").Value})
                             .OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var sport in sports) {
              Console.WriteLine("{0} ({1}年)", sport.Name,sport.Firstplayed);
            }
        }
        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value})
                             .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            Console.WriteLine("{0}({1}人)", sports.Name,sports.Teammembers);
        }     
        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                 new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                 new XElement("teammembers", "11"),
                 new XElement("firstplayed", "1863")
              );
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }
    }
}
