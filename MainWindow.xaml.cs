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

namespace WpfLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double summDollar = Convert.ToDouble(summ.Text);
            double resDollar = rateDollar * summDollar;
            result.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double summEuro = Convert.ToDouble(summ2.Text);
            double resEuro = rateEuro * summEuro;
            result2.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate3.Text);
            double summGrivna = Convert.ToDouble(summ3.Text);
            double resGrivna = rateGrivna * summGrivna;
            result3.Text = resGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate4.Text);
            double summeDrama = Convert.ToDouble(summ4.Text);
            double reseDrama = rateDrama * summeDrama;
            result4.Text = reseDrama.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inch = 39.37;
            double rateInch = Convert.ToDouble(rate5.Text);
            double resInch = rateInch / inch;
            result5.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double foot = 3.281;
            double rateFoot = Convert.ToDouble(rate6.Text);
            double resFoot = rateFoot / foot;
            result6.Text = resFoot.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double Mile = 1609;
            double rateMile = Convert.ToDouble(rate7.Text);
            double resMile = rateMile * Mile;
            result7.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double Verst = 1067;
            double rateVerst = Convert.ToDouble(rate8.Text);
            double resVerst = rateVerst * Verst;
            result8.Text = resVerst.ToString();
        }
    }
}
