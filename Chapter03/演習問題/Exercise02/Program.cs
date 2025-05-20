﻿

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("***** 3.2.1 *****");
            Exercise2_1(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.2 *****");
            Exercise2_2(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.3 *****");
            Exercise2_3(cities);
            Console.WriteLine();

            Console.WriteLine("***** 3.2.4 *****");
            Exercise2_4(cities);
            Console.WriteLine();
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var name = Console.ReadLine();  //入力処理
                if (string.IsNullOrEmpty(name)) 
                    break;
                int index = names.FindIndex(s => s.Equals(name));
                Console.WriteLine(index);
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine(names.Count(s => s.Contains('o')));
           //                 names.Count( ここにラムダ式を記述する )
        }

        private static void Exercise2_3(List<string> names) {
            var places = names.Where(s => s.Contains('o')).ToArray();
            foreach (var place in places) {
                Console.WriteLine(place);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var lengths = names
                .Where(s => s.StartsWith('B'))
                .Select(s => s.Length).ToList();
            lengths.ForEach(Console.WriteLine);
        }
    }
}
