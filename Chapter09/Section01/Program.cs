using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var today = DateTime.Today;//日付
            //var todays = new DateTime(2025, 7, 12);
            var now = DateTime.Now;//日付と時刻

            Console.WriteLine($"Today:{today}");
            Console.WriteLine($"Now:{now}");
            //打ち込んだ年月日は何曜日か調べる
            Console.Write("年:");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月:");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            var day = int.Parse(Console.ReadLine());

            DateTime ymd = new DateTime(year, month, day);
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = ymd.ToString("ggyy年M月d日",culture);
            var dayname = culture.DateTimeFormat.GetDayName(ymd.DayOfWeek);
            Console.WriteLine($"{str}は{dayname}です");
            //その日から現在まで何日目か
            TimeSpan tonow = DateTime.Today - ymd;
            Console.WriteLine($"その日から{tonow.Days}日目です");
            //年月日を閏年か判定する
            var leapyear = DateTime.IsLeapYear(year);
            if (leapyear) {
                Console.WriteLine("閏年です");
            } else {
                Console.WriteLine("閏年ではありません");
            }



        }
    }
}
