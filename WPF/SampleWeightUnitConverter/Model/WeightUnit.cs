using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter.Model {
    internal class WeightUnit {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public override string ToString() {
            return this.Name;
        }
    }
}
