using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            {
                var datetime = DateTime.Today;
                foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                    Console.WriteLine("{0:yy/MM/dd}の次週の{1}:", datetime, (DayOfWeek)dayofweek);
                    Console.WriteLine("{0:yy/MM/dd(ddd)}", NextWeek(datetime, (DayOfWeek)dayofweek));
                }
            }
        }
           
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
                    var nextweek = date.AddDays(7);
                    var days = (int)dayOfWeek - (int)(date.DayOfWeek);
                    return nextweek.AddDays(days);
                }
            }
        }
    

    
    

