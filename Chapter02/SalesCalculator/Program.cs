namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(SalesCounter.ReadSales(@"data\sales.csv"));
            Dictionary<string,int> amountsPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<String,int> obj in amountsPerStore) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }

        }

       



    }
}
