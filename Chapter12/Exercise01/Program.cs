using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employee {
                Id = 123,
                Name = "X",
                HireDate = new DateTime(2004, 9, 10)
            };
            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
               
         }
        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
               new Employee {
                   Id = 123,
                   Name = "出井　秀行",
                   HireDate = new DateTime(2004, 9, 10)
               },
               new Employee {
                   Id = 139,
                   Name = "大橋　工事",
                   HireDate = new DateTime(2004,4,8)
               },
           };

            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }


        }
        private static void Exercise1_3(string v) {
            using (XmlReader reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
               }
            }
        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[] {
               new Employee {
                   Id = 123,
                   Name = "出井　秀行",
                   HireDate = new DateTime(2004, 9, 10)
               },
               new Employee {
                   Id = 139,
                   Name = "大橋　工事",
                   HireDate = new DateTime(2004,4,8)
               },
           };


            // シリアル化したものをファイル出力
            using (var stream = new FileStream("employee", FileMode.Create, FileAccess.Write)) {
                
     // Jsonserializerを使ってシリアル化
                var options = new JsonSerializerOptions {
                    Encoder = JavaScriptEncoder.Create(UnicodeRange.All),
                    WriteIndented = true,
                };


                string jsonString = JsonSerializer.Serialize(emps,options);
                Console.WriteLine($"{jsonString}");

              //  File.WriteAllText("employee", jsonString);
            }
        }
    }
}
