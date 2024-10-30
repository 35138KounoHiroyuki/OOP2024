using System;
using System.Collections.Generic;
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

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        MyColor cureColor;//現在指定している色情報
        public MainWindow() {
            InitializeComponent();
            //aチャンネルの初期値を設定（起動時すぐにボタンが押された場合の対応）
            cureColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = GetColorList();
        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            cureColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            cureColor.Name = GetColorList().Where(c => c.Equals(cureColor))
                                           .Select(c => c.Name)
                                           .FirstOrDefault();
            
            colorArea.Background = new SolidColorBrush(cureColor.Color);
            //byte Red = (byte)rSlider.Value;
            //byte Green = (byte)gSlider.Value;
            //byte Blue = (byte)bSlider.Value;
            //colorArea.Background = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
         if (!stockList.Items.Contains((MyColor)cureColor)) {
                stockList.Items.Insert(0, cureColor);
                //byte Red = (byte)rSlider.Value;
                //byte Green = (byte)gSlider.Value;
                //byte Blue = (byte)bSlider.Value;
                //MyColor myColor = new MyColor {
                //    Color = Color.FromRgb(Red, Green, Blue),
                //    Name = ToString()
                //};
                //stockList.Items.Add(myColor);

            } else {
                MessageBox.Show("すでに登録済みです", "ColorChecker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex != -1) {
                var selectetColor =(MyColor)stockList.SelectedItem;

                colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
                setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            }
        }
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;


        }
        //rSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.R;
        //gSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.G;
        //bSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.B;
        //if (stockList.SelectedItem is MyColor myColor1) {
        //    colorArea.Background = new SolidColorBrush(myColor1.Color);



        private void ColorCombBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tmpMyColor = cureColor = (MyColor)((ComboBox)sender).SelectedItem;
            setSliderValue(tmpMyColor.Color);
            cureColor.Name = tmpMyColor.Name;
            //var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //var name = mycolor.Name;

        }

        private void btDelete_Click(object sender, RoutedEventArgs e) {
            // 選択されているアイテムを削除
            if (stockList.SelectedItem != null) {

                var result = MessageBox.Show("選択したアイテムを削除しますか？", "確認", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes) {
                    stockList.Items.Remove(stockList.SelectedItem);
                    // 選択をクリア
                    stockList.SelectedItem = -1;
                }
            } else {
                MessageBox.Show("削除するアイテムを選択してください。", "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}



