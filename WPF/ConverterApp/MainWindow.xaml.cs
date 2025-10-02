using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConverterApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private Dictionary<string,int> Metricunits = new Dictionary<string,int>() {
            {"mm",1 },
            {"cm",10 },
            {"m", 10*100 },
            {"km", 10*100*1000},
        };
        private Dictionary<string, int> Imperialunits = new Dictionary<string, int>() {
            {"in",1 },
            {"ft",12 },
            {"yd",12*3 },
            {"ml",12*3*1760},
        };
        public MainWindow() {
            InitializeComponent();
            MetricUnit.ItemsSource = Metricunits;
            ImperialUnit.ItemsSource = Imperialunits;
        }

        private void ImperialUnit_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
        public class DisUnits {
            public string name { get; set; }
            public double coefficient {  get; set; }
        }
    }
}
