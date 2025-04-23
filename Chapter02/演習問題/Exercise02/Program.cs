namespace Exercise02 {
    internal class Program {
        //インチとメートルを相互変換
        static void Main(string[] args) {
            Console.Write("インチからメートルなら0,逆なら1を入力:");
            int judge = int.Parse(Console.ReadLine());
            Console.Write("何in/何mから?:");
            int start = int.Parse(Console.ReadLine());
            Console.Write("何in/何mまで?:");
            int end = int.Parse(Console.ReadLine());
            if (judge == 0) {
                InchToMeterList(start, end);
            } else if (judge == 1) {
                MeterToInchList(start, end);
            } else {
                Console.WriteLine("エラー");
            }



            //インチからメートルの対応表を出力
            static void InchToMeterList(int start, int end) {
                if (start > end) {//降順での出力用
                    for (int inch = start; inch >= end; inch--) {
                        double meter = InchConverter.InchToMeter(inch);
                        Console.WriteLine($"{inch}in = {meter:0.0000}m");
                    }
                }
                for (int inch = start; inch <= end; inch++) {
                    double meter = InchConverter.InchToMeter(inch);
                    Console.WriteLine($"{inch}in = {meter:0.0000}m");
                }
            }
            //メートルからインチの対応表を出力
            static void MeterToInchList(int start, int end) {
                if (start > end) {//降順での出力用
                    for (int meter = end; meter >= start; meter++) {
                        double inch = InchConverter.MeterToInch(meter);
                        Console.WriteLine($"{meter}m = {inch:0.0000}in");
                    }
                }
                for (int meter = start; meter <= end; meter++) {
                    double inch = InchConverter.MeterToInch(meter);
                    Console.WriteLine($"{meter}m = {inch:0.0000}in");
                }
            }
        }
    }
}
