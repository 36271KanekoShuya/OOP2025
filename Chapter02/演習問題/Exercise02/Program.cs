namespace Exercise02 {
    internal class Program {
        //1～10インチをメートルに変換
        static void Main(string[] args) {
            InchToMeterList(1, 10);

            //インチからメートルの対応表を出力
            static void InchToMeterList(int start, int end) {
                for (int inch = start; inch <= end; inch++) {
                    double meter = InchConverter.InchToMeter(inch);
                    Console.WriteLine($"{inch}in = {meter:0.0000}m");
                }
            }
        }
    }
}
