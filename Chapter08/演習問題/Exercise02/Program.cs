namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            // コンストラクタの呼び出し
            var abbrs = new Abbreviations();
            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //8.2.3(Countの呼び出し例)
            Console.WriteLine($"用語数:{abbrs.Count}");
            Console.WriteLine();

            //8.2.3(Removeの呼び出し例)
            if (abbrs.Remove("NPT")) {
                Console.WriteLine("NPTを削除します");
                Console.WriteLine($"単語数:{abbrs.Count}");
            }
            Console.WriteLine();
            //すでに消したものへRemove
            if (!abbrs.Remove("NPT")) {
                Console.WriteLine("存在しない用語です");
            }
            //8.2.4(3文字の省略後だけ全て出力)
            
        }
    }
}
