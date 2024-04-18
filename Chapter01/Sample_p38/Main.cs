using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_p38 {
    internal class Program {
        static void Main(string[] args) {
            Employee employee = new Employee {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                Divisionname = "第一営業部",
            };
            Console.WriteLine("{}({})は、{}に所属しています。",
                                employee.Name, employee.GetAge(), employee.Divisionname);

            Console.WriteLine("{0} - {1}年");



            Person person = Student;
            if (person is Student)
                Console.WriteLine("person is Student");

            object obj = Student;
            if (obj is Student)
                Console.WriteLine("obj is Student");
        }
    }
}
