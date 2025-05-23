
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();
        }

        private static void Exercise1() {
            var value = Console.ReadLine();
            if (int.TryParse(value, out var num)) {
                if (num < 0) {
                    Console.WriteLine(num);
                } else if (num < 100) {
                    Console.WriteLine(num*2);
                } else if (num < 500) {
                    Console.WriteLine(num*3);
                } else{
                    Console.WriteLine(num);
                }
            } else {
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise2() {

        }

        private static void Exercise3() {

        }
    }
}
