using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismObservesSample {
    internal class MainWindowViewModel : BindableBase {
        private string _input1 = string.Empty;
        public string Input1 {
            get => _input1;
            set => SetProperty(ref _input1, value);
        }
        private string _input2 = string.Empty;
        public string Input2 {
            get => _input2;
            set => SetProperty(ref _input2, value);
        }
        private string _result = string.Empty;
        public string Result {
            get => _result;
            set => SetProperty(ref _result, value);
        }
        //コンストラクタ
        public MainWindowViewModel() {
            SumCommand = new DelegateCommand(ExcuteSum, CanExcuteSum)
                .ObservesProperty(() => Input1)
                .ObservesProperty(() => Input2);
        }

        public DelegateCommand SumCommand { get; }

        private bool CanExcuteSum() {
            return int.TryParse(Input1, out int term1) && int.TryParse(Input2, out int term2);
        }

        //加算処理
        private void ExcuteSum() {
            Result = (int.Parse(Input1) + int.Parse(Input2)).ToString();
        }
    }
}
