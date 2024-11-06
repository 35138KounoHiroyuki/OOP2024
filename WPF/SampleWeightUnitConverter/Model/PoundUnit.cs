using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter.Model {
    //ポンド単位を表すクラス
    public class PoundUnit :WeightUnit{
        private static List<PoundUnit> units = new List<PoundUnit> {
          new PoundUnit{Name = "oz",Coefficient = 1,},
          new PoundUnit{Name = "lb",Coefficient = 16,},
          new PoundUnit{Name = "st",Coefficient = 16*14,},
        };
        public static ICollection<PoundUnit> Units { get { return units; } }
        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromGramUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }

    }
}
