using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm}",dateTime));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            Console.WriteLine(dateTime.ToString("yyyy年MM月dd日 hh時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dateTime.ToString("ggy年M月d日",culture);
            var dayname = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            Console.WriteLine($"{str} ({dayname})");
        }
    }
}
