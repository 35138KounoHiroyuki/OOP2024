using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
        }

        private byte[] ConvertImageToByteArray(BitmapImage bitmapImage) {
            using (var memoryStream = new System.IO.MemoryStream()) {
                // BitmapImageをMemoryStreamに書き込み
                BitmapEncoder encoder = new PngBitmapEncoder(); // PNGエンコーダを使用
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(memoryStream);

                // MemoryStreamからバイト配列を取得
                return memoryStream.ToArray();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                MessageBox.Show("名前を入力してください", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Warning);
                return; // 名前が未入力の場合、登録処理を終了
            }

            // var    imagePath = (ImageContro.Source as BitmapImage)?.UriSource.ToString();
            byte[] imageData = null;
            if (ImageControl.Source != null) {
                // ImageControl から BitmapImage を取得し、バイト配列に変換
                var bitmapImage = ImageControl.Source as BitmapImage;
                if (bitmapImage != null) {
                    imageData = ConvertImageToByteArray(bitmapImage); // 画像をバイト配列に変換
                }
            }

            // 現在のデータベース内の顧客の最大Orderを取得
            int maxOrder;
            using (var connection = new SQLiteConnection(App.databasePass)) {
                maxOrder = connection.Table<Customer>().DefaultIfEmpty().Max(c => c?.Order ?? 0);
            }
            var customer = new Customer() {
              
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImageData = imageData,
                Order = maxOrder + 1,
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);

               
              
            }
            ReadDatabase();//ListView表示

            inputItemsAllClear();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {

            if (string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                string.IsNullOrWhiteSpace(PhoneTextBox.Text) &&
                string.IsNullOrWhiteSpace(AddressTextBox.Text)) {
                // 入力が不足している場合、エラーメッセージを表示
                MessageBox.Show("すべての項目を入力してください", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;  // 処理を終了して、更新を行わない
            }

            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください", "選択エラー", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 既存の顧客のOrderを保持
            int selectedCustomerOrder = selectedCustomer.Order;
            // 画像をバイナリデータに変換
            byte[] imageData = null;
            if (ImageControl.Source != null) {
                var bitmapImage = ImageControl.Source as BitmapImage;
                if (bitmapImage != null) {
                    imageData = ConvertImageToByteArray(bitmapImage); // 画像をバイト配列に変換
                }
            }
            // var imagePath = (ImageControl.Source as BitmapImage)?.UriSource.ToString();
            var updatedCustomer = new Customer() { 
                Id = selectedCustomer.Id,
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImageData = imageData,
                Order = selectedCustomerOrder  // 顧客の順番は変更しない
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(selectedCustomer);// 既存の顧客情報を削除
                connection.Insert(updatedCustomer);  // 新しい顧客情報を挿入
            }
            ReadDatabase();//ListView表示
            inputItemsAllClear();
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                 _customers = connection.Table<Customer>().ToList();

                _customers = connection.Table<Customer>().OrderBy(c => c.Order)  // Order 順に並べ替え
                                                         .ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SerchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SerchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);


                ReadDatabase();//ListView表示
                inputItemsAllClear();
            }

        }
        private BitmapImage ConvertByteArrayToImage(byte[] imageData) {
            using (var memoryStream = new System.IO.MemoryStream(imageData)) {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();  // UIスレッド以外からでも利用できるようにフリーズします
                return bitmapImage;
            }
        }
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                // 顧客情報をテキストボックスに表示
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                if (selectedCustomer.ImageData != null && selectedCustomer.ImageData.Length > 0) {
                    // バイナリデータから画像を読み込み
                    var image = ConvertByteArrayToImage(selectedCustomer.ImageData);
                    ImageControl.Source = image;
                } else {
                    // 画像データがない場合は画像表示をクリア
                    ImageControl.Source = null;
                }
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e) {
            // OpenFileDialogを使ってファイル選択ダイアログを表示
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";  // 画像ファイルのみフィルタリング
            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;

                // 画像をImageコントロールに表示
                ImageControl.Source = new BitmapImage(new Uri(filePath));
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            ImageControl.Source = null;
        }
        private void inputItemsAllClear() {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            SerchTextBox.Text = "";
            ImageControl.Source = null;
        }

        private void Clear_Click(object sender, RoutedEventArgs e) {
            inputItemsAllClear();
        }
    }
}
