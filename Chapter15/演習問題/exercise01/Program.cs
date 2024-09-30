using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b => b.Price == max);
            foreach (var books in book)
            {
                Console.WriteLine(books);
            }
           
        }

        private static void Exercise1_3() {
            var query = Library.Books.GroupBy(b => b.PublishedYear)
                               .Select(g => new { PublishedYear = g.Key, Count = g.Count() })
                               .OrderBy(x => x.PublishedYear);
            foreach (var item in query) {
                Console.WriteLine("{0}年 {1}冊", item.PublishedYear, item.Count);
            }
        }

        private static void Exercise1_4() {
            throw new NotImplementedException();
        }

        private static void Exercise1_5() {
            throw new NotImplementedException();
        }

        private static void Exercise1_6() {
            throw new NotImplementedException();
        }

        private static void Exercise1_7() {
            throw new NotImplementedException();
        }

        private static void Exercise1_8() {
            throw new NotImplementedException();
        }
    }
}
