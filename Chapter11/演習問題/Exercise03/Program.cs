using System.Text.RegularExpressions;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            string[] texts = [
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We reorganized the timetable.",
            ];
            foreach (var line in texts) {
                Match march = Regex.Match(line, @"\btime\b",RegexOptions.IgnoreCase);
                if (march.Success) 
                    Console.WriteLine($"{line},{march.Index}");//結果出力
            }
        }
    }
}
