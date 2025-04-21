namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product Karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(253, "大福もち", 160);

            //税抜価格
            Console.WriteLine(Karinto.Name + "の税抜き価格は" + Karinto.Price + "です。");
            Console.WriteLine(daifuku.Name + "の税抜き価格は" + daifuku.Price + "です。");
            //税額
            Console.WriteLine(Karinto.Name + "の税額は" + Karinto.GetTax() + "です。");
            Console.WriteLine(daifuku.Name + "の税額は" + daifuku.GetTax() + "です。");
            //税込
            Console.WriteLine(Karinto.Name + "の税込み価格は"
                                        + Karinto.GetPriceIncludingTax() + "です。");
            Console.WriteLine(daifuku.Name + "の税込み価格は"
                                        + daifuku.GetPriceIncludingTax() + "です。");



        }
    }
}
