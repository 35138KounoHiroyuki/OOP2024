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
        MyColor myColor;//現在指定している色情報
        public MainWindow() {
            MyColor[] GetColorList() {
                return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                    .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
            }
            InitializeComponent();
            //aチャンネルの初期値を設定（起動時すぐにボタンが押された場合の対応）
            //myColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //myColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            //colorArea.Background = new SolidColorBrush(myColor.Color);
            byte Red = (byte)rSlider.Value;
            byte Green = (byte)gSlider.Value;
            byte Blue = (byte)bSlider.Value;
            myColor.Name = null;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
            
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            if (!stockList.Items.Contains((MyColor)myColor)) {
                byte Red = (byte)rSlider.Value;
                byte Green = (byte)gSlider.Value;
                byte Blue = (byte)bSlider.Value;
                MyColor myColor = new MyColor {
                    Color = Color.FromRgb(Red, Green, Blue),
                    Name = ToString()
                };
                stockList.Items.Add(myColor);
               
            } else {
                MessageBox.Show("すでに登録済みです");
            }
        
            //  stockList.Items.Insert(0,myColor );

        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }
        private void setSliderValue(Color color) {
            rSlider.Value= color.R; 
            gSlider.Value= color.G;
            bSlider.Value= color.B;
        
        
        }
            //rSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.R;
            //gSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.G;
            //bSlider.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.B;
            //if (stockList.SelectedItem is MyColor myColor1) {
            //    colorArea.Background = new SolidColorBrush(myColor1.Color);

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tmpmyColor= myColor = (MyColor)((ComboBox)sender).SelectedItem;
            setSliderValue(myColor.Color);
            myColor.Name= tmpmyColor.Name;
            //var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //var name = mycolor.Name;

        }
    }
}


