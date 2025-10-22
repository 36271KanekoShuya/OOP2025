using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Cryptography;
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
        private List<Customer> _customers = new List<Customer>();
        private byte[]? _currentimage;

        public MainWindow() {
            InitializeComponent();

        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
            }
            CustomerListView.ItemsSource = _customers;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                MessageBox.Show("名前が未記入です");
                return;
            }
            if (_customers.Any(x => x.Phone == PhoneTextBox.Text)) {
                MessageBox.Show("番号が同じものがあります");
                return;
            }
            var person = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = _currentimage
            };

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Insert(person);
            }
            ReadDatabase();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item is null) {
                MessageLabel.Content ="削除するものがありません";
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
                MessageLabel.Content = "削除しました";
                ReadDatabase();
            }

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedperson = CustomerListView.SelectedItem as Customer;
            if (selectedperson is null) return;
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                var person = new Customer() {
                    Id = selectedperson.Id,
                    Name = NameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                };
                connection.Update(person);
                ReadDatabase();
            }
        }

        private void PictureButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
            if (ofd.ShowDialog() ?? false) {
                try {
                    _currentimage = File.ReadAllBytes(ofd.FileName);

                    // バイト配列からBitmapImageを作成して表示
                    using (var ms = new MemoryStream(_currentimage)) {
                        var bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.StreamSource = ms;
                        bitmap.EndInit();
                        bitmap.Freeze();
                        PictureBox.Source = bitmap;
                    }
                }
                catch (Exception ex) {
                    MessageLabel.Content = "画像の読み込みに失敗しました \n" + ex.Message;
                }
            }
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selecteditem = CustomerListView.SelectedItem as Customer;
            if (selecteditem is null) return;
            using (var ms = new MemoryStream(selecteditem.Picture)) {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = ms;
                bitmap.EndInit();
                bitmap.Freeze();
                PictureBox.Source = bitmap;
                NameTextBox.Text = selecteditem.Name;
                PhoneTextBox.Text = selecteditem.Phone;
                PictureBox.Source = bitmap;
            }
        }
    }
}