
namespace Section04 {
    internal class Program {
        static async Task Main(string[] args) {
            HttpClient hc = new HttpClient();
            await GetHtmlExample(hc);
        }

        static async Task GetHtmlExample(HttpClient http) {
            var url = "https://abehiroshi.la.coocan.jp/";
            var text = await http.GetStringAsync(url);
            Console.WriteLine(text);
        }
    }
}
