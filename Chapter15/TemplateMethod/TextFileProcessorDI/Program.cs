namespace TextFileProcessorDI {
    internal class Program {
        static void Main(string[] args) {
            var service = new LineOutputService();
            var processor = new TextFileProcessor(service);
            Console.Write("パスの入力：");
            string filename = Console.ReadLine();
            if (!string.IsNullOrEmpty(filename)) {
                return;
            }
            processor.Run(filename);
        }
    }
}
