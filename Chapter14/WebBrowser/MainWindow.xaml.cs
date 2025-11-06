using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.Security.Policy;
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
using System.Xml.Linq;

namespace WebBrowser {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InirializeAsync();
        }
        private async void InirializeAsync() {
            await WebView.EnsureCoreWebView2Async();
            WebView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            WebView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }
        //プログレスバー表示
        private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e) {
            LoadingBar.Visibility = Visibility.Visible;
            LoadingBar.IsIndeterminate =true;
        }
        //プログレスバー非表示
        private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e) {
            LoadingBar.Visibility = Visibility.Collapsed;
            LoadingBar.IsIndeterminate = false;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if (WebView.CanGoBack) {
                WebView.GoBack();
            }

        }

        private void FowardButton_Click(object sender, RoutedEventArgs e) {
            if (WebView.CanGoForward) {
                WebView.GoForward();
            }

        }

        private async void GoButton_Click(object sender, RoutedEventArgs e) {
            try {
                WebView.Source = new Uri(AddressBar.Text.Trim());

            }
            catch (InvalidOperationException) {
                MessageBox.Show("URIがありません");
                return;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
        }
    }
}