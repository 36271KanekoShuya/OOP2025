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
            ReadDatabase();
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
                MessageLabel.Content = "名前が未記入です";
                return;
            }
            if (_customers.Any(x => x.Phone == PhoneTextBox.Text)) {
                MessageLabel.Content = "番号が同じものがあります";
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
            ClearAllWriting();
        }

        /// <summary>
        ///テキストボックス内をすべて消す
        /// </summary>
        private void ClearAllWriting() {
            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            PictureBox.Source = null;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item is null) {
                MessageLabel.Content = "削除するものがありません";
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
                MessageLabel.Content = "削除しました";
                ReadDatabase();
                ClearAllWriting();
            }

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedperson = CustomerListView.SelectedItem as Customer;
            if (selectedperson is null) {
                MessageLabel.Content = "更新するものがありません";
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                var person = new Customer() {
                    Id = selectedperson.Id,
                    Name = NameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Address = AddressTextBox.Text,
                    Picture = _currentimage
                };
                connection.Update(person);
                ReadDatabase();
                MessageLabel.Content = "更新しました";
                ClearAllWriting();
            }
        }

        private void PictureButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
            if (ofd.ShowDialog() ?? false) {
                try {
                    _currentimage = File.ReadAllBytes(ofd.FileName);

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
            SaveButton.IsEnabled = false;
            var selecteditem = CustomerListView.SelectedItem as Customer;
            if (selecteditem is null) return;
            if (selecteditem.Picture is not null) {
                using (var ms = new MemoryStream(selecteditem.Picture)) {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = ms;
                    bitmap.EndInit();
                    bitmap.Freeze();
                    _currentimage = selecteditem.Picture;
                    PictureBox.Source = bitmap;
                    NameTextBox.Text = selecteditem.Name;
                    PhoneTextBox.Text = selecteditem.Phone;
                    AddressTextBox.Text = selecteditem.Address;
                }
            } else {
                NameTextBox.Text = selecteditem.Name;
                PhoneTextBox.Text = selecteditem.Phone;
                AddressTextBox.Text = selecteditem.Address;
            }

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text));

            CustomerListView.ItemsSource = filterList;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            ClearAllWriting();
            CustomerListView.SelectedIndex = -1;
            SaveButton.IsEnabled = true;
        }
    }
}