using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    internal class MainWindowViewModel : ViewModel {
        //フィールド
        private double metricValue;
        private double imperialValue;
        //▲で呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼で呼ばれるコマンド
        public ICommand MetricUnitToImperial { get; private set; }

        //上のコンボボックスで選択された値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のコンボボックスで選択された値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get => metricValue;
            set {
                metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get => imperialValue;
            set {
                imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        public MainWindowViewModel() {
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();
            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue =
                CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit, ImperialValue)
                );

            MetricUnitToImperial = new DelegateCommand(
                () => ImperialValue =
                CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, ImperialValue)
                );
        }
    }
}
