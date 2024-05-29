using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var st1 = Console.ReadLine();
            var st2 = Console.ReadLine();
            if (String.Compare(st1, st2, true) == 0)
                Console.WriteLine("ひとしい");
            else 
                Console.WriteLine("等しくない");
        }
    }
}
