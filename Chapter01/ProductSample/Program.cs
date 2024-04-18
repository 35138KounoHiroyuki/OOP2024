using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(777, "大福", 200);

           int karintoprices = karinto.Price;

            int daihukuPrice = daihuku.Price;
            int taxIncluded = karinto.GetPriceIncludingTax();//税込の金額
            int daihukutaxIncluded = daihuku.GetPriceIncludingTax();

            Console.WriteLine(karinto.Name + "の税込金額は"+taxIncluded+"円【"+ karintoprices + "円】") ;
            Console.WriteLine(daihuku.Name + "の税込金額は" + daihukutaxIncluded + "円【" + daihukuPrice + "円】");

       
        }
    }
}
