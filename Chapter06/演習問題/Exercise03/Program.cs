
using System.Reflection.PortableExecutable;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("--6.3.1--");
            Exercise1(text);

            Console.WriteLine("--6.3.2--");
            Exercise2(text);

            Console.WriteLine("--6.3.3--");
            Exercise3(text);

            Console.WriteLine("--6.3.4--");
            Exercise4(text);

            Console.WriteLine("--6.3.5--");
            Exercise5(text);

            Console.WriteLine("--6.3.99--");
            Exercise6(text);

        }

        

        private static void Exercise1(string text) {
            Console.WriteLine($"空白数:{text.Count(s => s == ' ')}");
        }

        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big","small"));
        }

        private static void Exercise3(string text) {
            var array = text.Split(' ');
            //Console.WriteLine(new StringBuilder().AppendJoin(' ',array));

            var sb = new StringBuilder();
            foreach (var word in array) {
                sb.Append(word);
                sb.Append(' ');
            }
            var Trimed = sb.ToString().TrimEnd();
            Console.WriteLine(Trimed + '.');
        }

        private static void Exercise4(string text) {
            Console.WriteLine($"単語数:{text.Split(' ').Count()}");
        }

        private static void Exercise5(string text) {
            text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);
        }
        
        private static void Exercise6(string text) {
            var lowtxt = text.ToLower();
            for(char chara = 'a';chara <= 'z'; chara++) {
                Console.WriteLine($"{chara}:{text.Count(s => s == chara)}");
            }
        }
    }
}
