﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {
        public double FeetToMeterList(double meter) {
            return meter * 0.3048;
        }
        public double MeterToFeetList(double feet) {
            return feet / 0.3048;
        }
    }
}
