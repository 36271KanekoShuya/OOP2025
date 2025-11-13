using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    internal class LineCounterProcessor : TextProcessor {
        private int _count = 0;
        string search = string.Empty;
        protected override void Initialize(string fname) {
            _count = 0;
            Console.Write("検索する単語を入力＞");
            search = Console.ReadLine();
            if (!string.IsNullOrEmpty(search)) {
                Console.WriteLine("入力してください");
                return;
            }
        }

        protected override void Execute(string line) {
            if (line.Contains(search)) {
                _count++;
            }
        }

        protected override void Terminate() => Console.WriteLine("{0}個", _count);
    }
}
