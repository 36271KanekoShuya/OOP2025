namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("--本の平均金額--");
            Console.WriteLine(Math.Round(books.Average(x => x.Price))+"円");

            Console.WriteLine("--ページ合計--"); 
            Console.WriteLine(books.Sum(x => x.Pages)+"頁");

            Console.WriteLine("--安い書籍名とその金額を全出力--");
            books.Where(x => x.Price == books.Min(b =>b.Price)).ToList()
                .ForEach(x => Console.WriteLine($"{x.Title}:{x.Price}円"));

            Console.WriteLine("--ページの多い書籍名とそのページ数を全出力--");
            books.Where(x => x.Pages == books.Max(b => b.Pages)).ToList()
                .ForEach(x => Console.WriteLine($"{x.Title}:{x.Pages}頁"));

            Console.WriteLine("--タイトルに物語が含まれている書籍を全出力--");
            books.Where(x => x.Title.Contains("物語")).ToList().ForEach(x =>Console.WriteLine(x.Title));
        }
    }
}
