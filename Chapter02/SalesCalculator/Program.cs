namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(@"data\sales.csv");
            IDictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<String, int> obj in amountsPerStore) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }
        }
    }
}
