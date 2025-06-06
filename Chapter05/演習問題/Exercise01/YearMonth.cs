using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public readonly int year;
        public readonly int month;

        public YearMonth(int year, int month) {
            this.year = year;
            this.month = month;
        }


        //5.1.2
        //設定されている西暦が21世紀か判定する
        //Yearが2001～2100年の間ならtrue、それ以外ならfalseを返す
        public bool Is21Century => 2001 <= year && year <= 2100;

        //5.1.3
        public YearMonth AddOneMonth() {
            YearMonth rtn;
            if (year == 12) {
                rtn = new YearMonth(year + 1, 1);
            } else {
                rtn = new YearMonth(year, month + 1);
            }
            return rtn;
        }
        //5.1.4
        public override string ToString() => $"{year}年{month}月";
    }
}
