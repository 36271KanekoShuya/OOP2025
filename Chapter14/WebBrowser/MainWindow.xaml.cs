using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WebBrowser {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            WebView.GoBack();
        }

        private void FowardButton_Click(object sender, RoutedEventArgs e) {
            WebView.GoForward();
        }

        private async void GoButton_Click(object sender, RoutedEventArgs e) {
            try {
                WebView.Source = new Uri(AddressBar.Text);

            }
            catch (InvalidOperationException) {
                MessageBox.Show("URIがありません");
                return;
            }
            catch (Exception ex) {
                MessageBox.Show (ex.Message);
                return;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
        }
    }
}