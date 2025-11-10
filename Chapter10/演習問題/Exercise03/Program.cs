namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("書き足されるファイル＞");
            var writeFile = Console.ReadLine() ?? "source.txt";
            Console.Write("書き足すファイル＞");
            var readFile = Console.ReadLine() ?? "source2.txt";
            var text1 = File.ReadAllLines(writeFile);
            var text2 = File.ReadAllLines(readFile);
            using (var writer = new StreamWriter(writeFile, append: true)) {
                foreach (var line in text2) {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
