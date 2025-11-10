using System.Text;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var filePath = "source.txt";
            CountClass1(filePath);
            CountClass2(filePath);
            CountClass3(filePath);
        }

        private static void CountClass3(string filePath) {
            Console.WriteLine(File.ReadLines(filePath, Encoding.UTF8)
                .Count(x => x.Contains("class")));
        }

        private static void CountClass2(string filePath) {
            Console.WriteLine(File.ReadAllLines(filePath, Encoding.UTF8)
                .Count(x => x.Contains("class")));
        }

        private static void CountClass1(string filePath) {
            if (File.Exists(filePath)) {
                int cnt = 0;
                using var reader = new StreamReader(filePath, Encoding.UTF8);
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine().Split(' ')
                        .ToList().Where(x => x.Contains("class"));
                    if (line.Count() > 0) {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
