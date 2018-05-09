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

namespace BMI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // 滑動身高Slider時所觸發的事件
        private void h_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e){

            // 將身高數值顯示出來
            heightNum.Text = heightSlider.Value.ToString();
            // 將bmi數值顯示出來
            bmiNum.Text = BmiCount() + " bMI值";
        }
        // 滑動體重Slider時所觸發的事件
        private void w_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e){
            
            // 將體重數值顯示出來
            weightNum.Text = weightSlider.Value.ToString();
            // 將bmi數值顯示出來
            bmiNum.Text = BmiCount() + " bMI值";

        }

        // 計算bmi的自訂方法
        public double BmiCount() {

            return Math.Round(weightSlider.Value / ((heightSlider.Value / 100) * (heightSlider.Value / 100)), 2);

        }
        
    }
}
