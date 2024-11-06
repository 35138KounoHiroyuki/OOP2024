﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter.Model {
    //グラム単位を表すクラス
    public class GramUnit :WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
          new GramUnit{Name = "g",Coefficient = 1,},
          new GramUnit{Name = "kg",Coefficient =1000},
          new GramUnit{Name = "t",Coefficient = 1000*1000,},

        };
        public static ICollection<GramUnit> Units { get { return units; } }
        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromIPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }
}
