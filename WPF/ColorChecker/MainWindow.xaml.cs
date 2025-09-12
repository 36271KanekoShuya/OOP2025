using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summar>
    /// MainWindow.xaml の相互作用ロジック
    /// </summar>
    public partial class MainWindow : Window {

        MyColor currentcolor;

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, EventArgs e) {
            colorSelectComboBox.SelectedItem = new MyColor {
                Color = Color.FromRgb(0, 0, 0),
                Name = "Black",
            };
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //colorAreaに指定したRGBの色を表示
            currentcolor = new MyColor {
                Color = Color.FromRgb((byte)redColorSlider.Value,
                (byte)greenColorSlider.Value, (byte)blueColorSlider.Value),
                Name = ((MyColor[])DataContext).Where(c =>
                                                      c.Color.R == (byte)redColorSlider.Value &&
                                                      c.Color.B == (byte)blueColorSlider.Value &&
                                                      c.Color.G == (byte)greenColorSlider.Value).Select(x => x.Name).FirstOrDefault(),
            };
            colorArea.Background = new SolidColorBrush(currentcolor.Color);
            if (currentcolor.Name == null) {
                colorSelectComboBox.SelectedIndex = -1;
            } else {
                if (currentcolor.Name == "Transparent") {
                    currentcolor = new MyColor {
                        Color = Color.FromRgb(255, 255, 255),
                        Name = "White",
                    };
                }
                colorSelectComboBox.SelectedItem = currentcolor;
            }

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            //重複排除
            if (stockList.Items.Contains(currentcolor)) {
                MassageLabel.Content = "Already stocked.";
                return;
            } else {
                stockList.Items.Add(currentcolor);
                MassageLabel.Content = "Stock completed.";
            }

        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (((ComboBox)sender).SelectedItem != null) {
                var selemycolor = (MyColor)((ComboBox)sender).SelectedItem;
                currentcolor = selemycolor;
                setSliderValue(selemycolor.Color);
            }

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedItem != null) {
                var color = (MyColor)stockList.SelectedItem;
                setSliderValue(color.Color);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedItem != null) {
                stockList.Items.Remove((MyColor)stockList.SelectedItem);
                MassageLabel.Content = "Delete completed.";
            } else {
                MassageLabel.Content = "Already deleted";
            }
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        /// <summar>
        /// RGBスライダ一の値を変えるメソッド
        /// </summar>
        /// <param name="color"></param>
        private void setSliderValue(Color color) {
            redColorSlider.Value = color.R;
            greenColorSlider.Value = color.G;
            blueColorSlider.Value = color.B;
        }

    }
}
