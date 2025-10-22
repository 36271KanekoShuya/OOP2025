using CustomerApp.Data;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Customer> _persons = new List<Customer>();
        public MainWindow() {
            InitializeComponent();

        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                _persons = connection.Table<Customer>().ToList();

            }
            PersonListView.ItemsSource = _persons;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {

        }

        private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void PictureButton_Click(object sender, RoutedEventArgs e) {

        }
    }
}