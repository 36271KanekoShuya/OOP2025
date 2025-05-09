﻿namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(ReadSales(@"data\sales.csv"));
            Dictionary<string,int> amountsPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<String,int> obj in amountsPerStore) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }

        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            //売り上げデータを入れるリストオブジェクトを作成
            List<Sale> sales = new List<Sale>();
            //ファイルを一斉読み込み
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale() {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);

            }

            return sales;
        }



    }
}
