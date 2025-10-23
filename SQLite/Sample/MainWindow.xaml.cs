using Sample.Data;
using SQLite;
using System.Collections.ObjectModel;
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

namespace Sample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Person> _persons = new List<Person>();
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();

        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
                _persons = connection.Table<Person>().ToList();

            }
            PersonListView.ItemsSource = _persons;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                MessageBox.Show("名前が未記入です");
                return;
            }
            if (_persons.Any(x => x.Phone == PhoneTextBox.Text)) {
                MessageBox.Show("番号が同じものがあります");
                return;
            }
            var person = new Person() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                
            };

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
                connection.Insert(person);
            }

        }

        private void ReadButton_Click(object sender, RoutedEventArgs e) {
            ReadDatabase();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = PersonListView.SelectedItem as Person;
            if (item is null) {
                MessageBox.Show("削除するものがありません");
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Person>();
                connection.Delete(item);
                ReadDatabase();
            }

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedperson = PersonListView.SelectedItem as Person;
            if (selectedperson is null) return;
                using (var connection = new SQLiteConnection(App.databasePath)) {
                    connection.CreateTable<Person>();
                    var person = new Person() {
                        Id = selectedperson.Id,
                        Name = NameTextBox.Text,
                        Phone = PhoneTextBox.Text,
                    };
                    connection.Update(person);
                    ReadDatabase();
                }
            }
        //リストビューのフィルタリング
        private void SearchTextbox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _persons.Where(x => x.Name.Contains(SearchTextbox.Text));

            PersonListView.ItemsSource = filterList;
        }

        private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selecteditem = PersonListView.SelectedItem as Person;
            if (selecteditem is null) return;
            NameTextBox.Text = selecteditem.Name;
            PhoneTextBox.Text = selecteditem.Phone;
        }
    }
}