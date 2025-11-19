namespace TextFileProcessorDI {
    internal class Program {
        static void Main(string[] args) {
            var service = new LineHalfNumberService();
            var processor = new TextFileProcessor(service);
            Console.Write("パスの入力：");
            string filename = Console.ReadLine();
            if (string.IsNullOrEmpty(filename)) {
                Console.WriteLine("何もない");
                return;
            }
            if (!File.Exists(filename)) {
                Console.WriteLine("ファイルない");
                return;
            }
            processor.Run(filename);
        }
    }
}
