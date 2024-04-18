using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力

                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetLisit(int.Parse(args[1]), int.Parse(args[2]));


            }
        }

        private static void PrintMeterToFeetLisit(int start, int stop) {
           
            for (int feet = 1; feet <= 10; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }

        private static void PrintFeetToMeterList(int start, int stop) {
           
            for (int meter = 1; meter <= 10; meter++) {
                double feet =FeetConverter.FrmoMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}ft", meter, feet);
            }
        }

    }
}
        

       

      
