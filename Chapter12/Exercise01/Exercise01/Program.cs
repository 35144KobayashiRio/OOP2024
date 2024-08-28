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

        private static void Exercise1_1(string outfile) {
            var emp = new Employee {
                Id = 123,
                Name = "中山　翼",
                HireDate = new DateTime(2002, 5, 11),
            };

            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
        }

        private static void Exercise1_2(string outfile) {
            var emps = new Employee[] {
                new Employee {
                Id = 173,
                Name = "高橋　直人",
                HireDate = new DateTime(2001, 4, 8),
            },
            new Employee {
                Id = 459,
                Name = "石川　有紗",
                HireDate = new DateTime(2003, 12, 7),
            },
        };

            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string file) {
            using (var reader = XmlReader.Create(file)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var em = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in em) {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
                }
            }
        }

        private static void Exercise1_4(string file) {
            var emps = new Employee[] {
                new Employee {
                Id = 173,
                Name = "高橋　直人",
                HireDate = new DateTime(2001, 4, 8),
            },
            new Employee {
                Id = 459,
                Name = "石川　有紗",
                HireDate = new DateTime(2003, 12, 7),
            },
        };

            using (var stream = new FileStream(file, FileMode.Create, FileAccess.Write)) {
                var options = new JsonSerializerOptions {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase, //キー名のカスタマイズ
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(stream, emps, options);
            }
        }
    }
}