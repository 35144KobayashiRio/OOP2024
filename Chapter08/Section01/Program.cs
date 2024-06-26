using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("生年月日を入力");
            Console.Write("年:");
            int year = int.Parse(Console.ReadLine());

            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());

            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            //あなたは○○年〇月〇日〇曜日に生まれました
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = birthday.ToString("ggyy年M月d日dddd", culture);
            Console.WriteLine("あなたは" + str + "に生まれました。");



            //あなたは生まれてから今日で○○○○日目です。
            var today = DateTime.Today;
            TimeSpan diff = today - birthday;
            Console.WriteLine("あなたは生まれてから今日で{0}日目です", diff.Days + 1);

        }
    }
}





//            DayOfWeek daysOfWeeks = birthday.DayOfWeek;

//            switch (daysOfWeeks) {
//                case DayOfWeek.Sunday:
//                    Console.WriteLine("日曜日");
//                    break;

//                case DayOfWeek.Monday:
//                    Console.WriteLine("月曜日");
//                    break;

//                case DayOfWeek.Tuesday:
//                    Console.WriteLine("火曜日");
//                    break;

//                case DayOfWeek.Wednesday:
//                    Console.WriteLine("水曜日");
//                    break;

//                case DayOfWeek.Thursday:
//                    Console.WriteLine("木曜日");
//                    break;

//                case DayOfWeek.Friday:
//                    Console.WriteLine("金曜日");
//                    break;

//                case DayOfWeek.Saturday:
//                    Console.WriteLine("土曜日");
//                    break;

//            }
//        }
//    }
//}



//            var dt1 = new DateTime(2024, 6, 19);
//            var dt2 = new DateTime(2010, 11, 25, 8, 45, 20);
//            Console.WriteLine(dt1);
//            Console.WriteLine(dt2);

//            var today = DateTime.Today;
//            var now = DateTime.Now;
//            Console.WriteLine("Today:{0}", today);
//            Console.WriteLine("Now:{0}", now);

//            var isLeapYear = DateTime.IsLeapYear(2024);
//            if (isLeapYear) {
//                Console.WriteLine("閏年です。");
//            } else {
//                Console.WriteLine("閏年ではありません。");
//            }
//        }
//    }
//}