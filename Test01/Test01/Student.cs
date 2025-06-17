using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01 {
    public class Student {
        public string Name { get; private set; } = string.Empty;//学生の名前
        public string Subject { get; private set; } = string.Empty;//科目名
        public int Score { get; private set; }//点数

    }
}
