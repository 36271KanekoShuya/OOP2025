namespace Section04 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            IEnumerable<string> query = cities
                .Select(s => s.ToUpper())
                .OrderBy(s => s[0]);

            foreach (var s in query) {
                Console.WriteLine(s);
            }
        }
    }
}
