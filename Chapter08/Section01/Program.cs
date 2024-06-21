using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
           　int year =int.Parse (Console.ReadLine());
            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int day =int.Parse (Console.ReadLine());

            var birtday= new DateTime(year, month, day);
            DayOfWeek dayOfWeek = birtday.DayOfWeek;

            //あなたは平成00年０月０日０曜日に生まれました
            
            var culture = new CultureInfo("ja-jp");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = birtday.ToString("ggyy年M月d日", culture);
            Console.WriteLine("あなたは平成"+str+ birtday.ToString("ddd")+"曜日に生まれました");
          //  Console.WriteLine();//(金)

            //あなたは生まれてから今日で００００日目です
            var nowdate = DateTime.Today;
            var totaidays = nowdate.Subtract(birtday).TotalDays;
            Console.WriteLine("あなたは生まれてから今日で"+totaidays+ "日目です");


            }
        }
    }

