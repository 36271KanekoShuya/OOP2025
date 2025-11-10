namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var readFile = "source.txt";
            var writeFile = "initialnumber.txt";
            var texts = File.ReadLines(readFile)
                .Select((s, ix) => $"{ix + 1,4}: {s}");
            using (var writer = new StreamWriter(writeFile)) {
                foreach (var line in texts) {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
