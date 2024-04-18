using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {
        public double FrmoMeter(double meter) {
            return meter / 0.3048;
        }
        public double ToMeter(double feet) {
            return feet * 0.3048;
        }
    }
}

