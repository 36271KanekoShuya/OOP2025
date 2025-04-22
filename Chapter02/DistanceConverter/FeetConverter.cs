using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {
        //定数
        private const double ratio = 0.3048;
        //フィートからメートルを求める
        public static double FeetToMeter(double feet) {
            return feet * ratio;
        }
        //メートルからフィートを求める
        public static double MeterToFeet(double meter) {
            return meter / ratio;
        }
    }
}
