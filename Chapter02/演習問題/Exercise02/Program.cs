namespace Exercise02 {
    internal class Program {
        //ヤードとメートルの相互変換
        static void Main(string[] args) {
            Console.WriteLine("ヤードからメートルなら0を入力");
            Console.Write("メートルからヤードなら1を入力:");
            int judge = int.Parse(Console.ReadLine());
            if (judge == 0) {
                Console.Write("変換前（ヤード）:");
                int num = int.Parse(Console.ReadLine());
                YardToMeterPrint(num);
            } else if (judge == 1) {
                Console.Write("変換前（メートル）:");
                int num = int.Parse(Console.ReadLine());
                MeterToYardPrint(num);
            } else {
                Console.WriteLine("エラー");
            }


            //ヤードからメートルの変換を出力
            static void YardToMeterPrint(int yard) {
                double meter = YardConverter.YardToMeter(yard);
                Console.WriteLine($"変換後（メートル）:{meter:0.000}");
            }
            //メートルからヤードの変換を出力
            static void MeterToYardPrint(int meter) {
                double yard = YardConverter.MeterToYard(meter);
                Console.WriteLine($"変換後（ヤード）:{yard:0.000}");
            }
        }
    }
}
