namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("書き足されるファイル＞");
            var writeFile = Console.ReadLine();
            if (writeFile == "") {
                writeFile = "source.txt";
            }
            Console.Write("書き足すファイル＞");
            var readFile = Console.ReadLine() ;
            if (readFile == "") {
                readFile = "source2.txt";
            }
            var text = File.ReadAllLines(readFile);
            using (var writer = new StreamWriter(writeFile, append: true)) {
                foreach (var line in text) {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
