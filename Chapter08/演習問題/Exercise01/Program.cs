using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            // 2019/1/15 19:48 
            var str = string.Format("{0:yyyy/M/d HH:mm}", dateTime);
            Console.WriteLine(str);
        }
        private static void DisplayDatePattern2(DateTime dateTime) {
            // 2019年01月15日 19時48分32秒 
            var str = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(str);
        }
        private static void DisplayDatePattern3(DateTime dateTime) {
            // 平成31年 1月15日(火曜日)           
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datestr = dateTime.ToString("ggyy", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var str = string.Format("{0}年{1,2}月{2,2}日({3})", datestr, dateTime.Month, dateTime.Day, dayOfWeek);
            Console.WriteLine(str);
        }           
    }
}
