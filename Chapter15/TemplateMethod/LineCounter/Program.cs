using TextFileProcessor;
namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            Console.Write($"ファイルパスを入力({""}はとること)＞");
            string filename = Console.ReadLine();

            if (!File.Exists(filename)) {
                Console.WriteLine("存在していないようです");
                return;
            }

            TextProcessor.Run<LineCounterProcessor>(filename);
        }
    }
}
