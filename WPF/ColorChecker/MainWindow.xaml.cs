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
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        private ObservableCollection<MyColor> myColors = new ObservableCollection<MyColor>();

        MyColor currentcolor;
        public MainWindow() {
            InitializeComponent();
            stockList.ItemsSource = myColors;
            colorSelectComboBox.DataContext = GetColorList();
        }


        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //colorAreaに指定したRGBの色を表示
            var backcolor = new MyColor {
                Color = Color.FromRgb((byte)redColorSlider.Value,
                (byte)greenColorSlider.Value, (byte)blueColorSlider.Value),
                Name = null
            };
            colorArea.Background = new SolidColorBrush(backcolor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            var color = Color.FromRgb((byte)redColorSlider.Value,
                (byte)greenColorSlider.Value, (byte)blueColorSlider.Value);
            if (colorSelectComboBox.SelectedItem != null) {
                var listcolors = new MyColor {
                    //Color = colorSelectComboBox.Items,
                };
            }
            var colors = new MyColor {
                Color = color,
            };
            //重複の排除
            if (myColors.Contains(colors)) {
                return;
            } else {
                myColors.Add(colors);
            }

        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selemycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = selemycolor.Color;
            var name = selemycolor.Name;
            setSliderValue(color);
        }


        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        /// <summary>
        /// RGBスライダーの値を変えるメソッド
        /// </summary>
        /// <param name="color"></param>
        private void setSliderValue(Color color) {
            redColorSlider.Value = color.R;
            greenColorSlider.Value = color.G;
            blueColorSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //var color = myColors[(stockList.SelectedIndex)];

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            //var deleter = ((ListBoxItem)sender).ToString();
            myColors.Remove((MyColor)stockList.SelectedItem);
        }

        private void redColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

        }
    }
}
