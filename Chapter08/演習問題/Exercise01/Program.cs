
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine("====================");

            Exercise2(text);

        }

        private static void Exercise1(string text) {
            var alpdic = new Dictionary<char, int>();
            foreach (var alpha in text.ToUpper()) {
                if ('A' <= alpha && alpha <= 'Z') {
                    if (alpdic.ContainsKey(alpha)) {
                        alpdic[alpha]++;
                    } else {
                        alpdic[alpha] = 1;
                    }
                }
            }
            alpdic.OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"{x.Key}:{x.Value}"));
            //foreach (var alpha in alpdic.OrderBy(X => X.Key)) {
            //    Console.WriteLine($"{alpha.Key}:{alpha.Value}");
            //}
        }

        private static void Exercise2(string text) {
            var alpdic = new SortedDictionary<char, int>();
            foreach (var alpha in text.ToUpper()) {
                if ('A' <= alpha && alpha <= 'Z') {
                    if (alpdic.ContainsKey(alpha)) {
                        alpdic[alpha]++;
                    } else {
                        alpdic[alpha] = 1;
                    }
                }
            }
            alpdic.ToList().ForEach(x => Console.WriteLine($"{x.Key}:{x.Value}"));
        }
    }
}
