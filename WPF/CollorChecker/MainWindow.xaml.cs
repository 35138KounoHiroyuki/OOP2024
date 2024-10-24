using System;
using System.Collections.Generic;
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

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor myColor;//現在指定している色情報
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //myColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            //colorArea.Background = new SolidColorBrush(myColor.Color);
            byte Red = (byte)rSlider.Value;
            byte Green = (byte)gSlider.Value;
            byte Blue = (byte)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
          //  stockList.Items.Insert(0,myColor);

            byte Red = (byte)rSlider.Value;
            byte Green = (byte)gSlider.Value;
            byte Blue = (byte)bSlider.Value;
            MyColor myColor = new MyColor {
                Color = Color.FromRgb(Red, Green, Blue),
                Name = ToString()
            };
            stockList.Items.Add(myColor);

            
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedItem is MyColor myColor1) {
                colorArea.Background = new SolidColorBrush(myColor1.Color);
            }
        }
    }
}
