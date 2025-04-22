using System;

namespace DistanceConverter {
    internal class Program {
        // コマンドライン引数で指定された範囲のフィートとメートルの対応表を出力
        static void Main(string[] args) {

            int start = int.Parse(args[1]);//始点
            int end = int.Parse(args[2]);//終点
            if (args.Length >= 1 && args[0].Equals("-tom")) {
                //フィートからメートルへの対応表を出力
                FeetToMeterList(start, end);
            } else if (args[0].Equals("-tof")) {
                //メートルからフィートへの対応表を出力
                MeterToFeetList(start, end);
            }

        }
        static void FeetToMeterList(int start, int end) {
            //Console.Write("何ftから?:");//入力用
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("何ftまで?:");
            //int end = int.Parse(Console.ReadLine());
            FeetConverter feettometer = new FeetConverter();
            for (int feet = start; feet <= end; feet++) {
                double meter = feettometer.FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
        static void MeterToFeetList(int start, int end) {
            //Console.Write("何mから?:");//入力用
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("何mまで?:");
            //int end = int.Parse(Console.ReadLine());
            FeetConverter metertofeet = new FeetConverter();
            for (int meter = start; meter <= end; meter++) {
                double feet = metertofeet.MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}
