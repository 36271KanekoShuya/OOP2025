
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class Settings {
        //設定した色の情報を格納
        public int MainFormBackColor {  get; set; }

        private static Settings? instance;
        public static Settings getInstance() {
            if (instance is null) {
                instance = new Settings();
            }
            return instance;
        }

        private Settings() { }

    }
}
