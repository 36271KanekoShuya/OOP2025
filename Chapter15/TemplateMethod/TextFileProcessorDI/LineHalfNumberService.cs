using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    public class LineHalfNumberService : ITextFileService {
        public static Dictionary<char, char> dictionary = new Dictionary<char, char>() {
        {'０','0'},{'１','1'},{'２','2'},{'３','3'},
        {'４','4'},{'５','5'},{'６','6'},{'７','7'},
        {'８','8'},{'９','9'}
        };
        private int _count;
        public void Initialize(string fname) {
            _count = 0;

        }

        public void Execute(string line) {
            _count++;
            Regex regex = new Regex("[０-９]+");
            var numhalfed = regex.Replace(line, Replacer);
            Console.WriteLine(_count +"|"+ numhalfed);
        }

        public void Terminate() {

        }

        public static string Replacer(Match m) {
            return new string(
              m.Value.Select(n => dictionary[n]).ToArray()
              );
        }

    }
}
