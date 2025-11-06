namespace Section05 {
    internal class Program {
        static void Main(string[] args) {

            Parallel.For(0, 100, i => {
                Console.WriteLine($"処理a-{i}開始");
                Thread.Sleep(1000);
                Console.WriteLine($"処理a-{i}終了");
            });


            Console.WriteLine("--------並列処理なし-------");
            for(int i = 0; i < 10; i++) {
                Console.WriteLine($"処理b-{i}開始");
                Thread.Sleep(1000);
                Console.WriteLine($"処理b-{i}終了");
            }
        }
    }
}
