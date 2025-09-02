using System.Text.RegularExpressions;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            string filepass = "sample.txt";
            Pickup3Digitnumber(filepass);
            Console.WriteLine("=======================");
            Pickup3Words(filepass);
        }

        private static void Pickup3Digitnumber(string filepass) {
            foreach (var line in File.ReadLines(filepass)) {
                var marches = Regex.Matches(line,@"\b[0-9]{3,}\b");
                foreach (Match m in marches) {
                    Console.WriteLine(m.Value);//結果出力
                }
            }
        }

        private static void Pickup3Words(string filepass) {
            foreach (var line in File.ReadLines(filepass)) {
                var marches = Regex.Matches(line, @"\b[a-zA-Z]{3,}\b");
                foreach (Match m in marches) {
                    Console.WriteLine(m.Value);//結果出力
                }
            }
        }
    }
}
