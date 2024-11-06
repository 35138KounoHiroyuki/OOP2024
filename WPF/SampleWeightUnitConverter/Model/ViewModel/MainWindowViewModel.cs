using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWeightUnitConverter.Model.ViewModel {
    public class MainWindowViewModel  {
        private double gramValue, poundValue;

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        //上のコンボボックスで選択される値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のコンボボックスで選択される値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get { return metricValue; }
            set {
                metricValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        public double ImperialValue {
            get { return imperialValue; }
            set {
                imperialValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }
        //コンストラクタ
        public MainWindowViewModel() {
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();

            MetricToImperialUnit = new DelegateCommand(() => ImperialValue = CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, MetricValue));

            ImperialUnitToMetric = new DelegateCommand(() => MetricValue = CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit, ImperialValue));

        }

    }
}
