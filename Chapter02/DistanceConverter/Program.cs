using System;

namespace DistanceConverter {
    internal class Program {
        // コマンドライン引数で指定された範囲のフィートとメートルの対応表を出力
        static void Main(string[] args) {
            //Console.Write("何ft/何mから?:");//入力用
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("何ft/何mまで?:");
            //int end = int.Parse(Console.ReadLine());

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
        //フィートからメートルへの対応表を出力
        static void FeetToMeterList(int start, int end) {
            for (int feet = start; feet <= end; feet++) {
                double meter = FeetConverter.FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
        //メートルからフィートへの対応表を出力
        static void MeterToFeetList(int start, int end) {
            for (int meter = start; meter <= end; meter++) {
                double feet = FeetConverter.MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}
