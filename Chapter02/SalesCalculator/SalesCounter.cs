using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    public class SalesCounter {
        private readonly IEnumerable<Sale> _sales;

        /// <summary>
        /// ReadSealsメソッドにリストを送るコンストラクタ
        /// </summary>
        /// <param name="filePath"></param>
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }
        /// <summary>
        /// 店舗別売り上げを求めるメソッド
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;
                } else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
        /// <summary>
        /// 売り上げデータを読み込み、Saleオブジェクトのリストを返すメソッド
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private IEnumerable<Sale> ReadSales(string filePath) {
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
