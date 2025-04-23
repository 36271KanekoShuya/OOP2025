using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class YardConverter {
        private const double ratio = 1.0936;
        //ヤードからメートルを求める
        public static double YardToMeter(double yard) {
            return yard / ratio;
        }
        //メートルからヤードを求める
        public static double MeterToYard(double meter) {
            return meter * ratio;
        }
    }
}
