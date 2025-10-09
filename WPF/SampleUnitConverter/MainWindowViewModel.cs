using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    internal class MainWindowViewModel : BindableBase {
        //フィールド
        private double metricValue = 0;
        private double imperialValue = 0;
        //▲で呼ばれるコマンド
        public DelegateCommand ImperialUnitToMetric { get; private set; }
        //▼で呼ばれるコマンド
        public DelegateCommand MetricUnitToImperial { get; private set; }

        //上のコンボボックスで選択された値
        public MetricUnit? CurrentMetricUnit { get; set; }
        //下のコンボボックスで選択された値
        public ImperialUnit? CurrentImperialUnit { get; set; }

        public double MetricValue {
            get => metricValue;
            set => SetProperty(ref metricValue, value);
        }

        public double ImperialValue {
            get => imperialValue;
            set => SetProperty(ref imperialValue, value);
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
                CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, MetricValue)
                );
        }
    }
}
