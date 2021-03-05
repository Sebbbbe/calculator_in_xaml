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

namespace calculater_training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string empty = "";
        float number1 = 0;
        float total = 0;
        float totalNumbers = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
      
	


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            number1 = 1;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            number1 = 2;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            number1 = 3;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            number1 = 4;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            number1 = 5;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            number1 = 6;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            number1 = 7;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            number1 = 8;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            number1 = 9;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "0";
            totalNumbers = total;
            total = 0;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            totalNumbers = totalNumbers + total;
            txtBox.Text = totalNumbers.ToString();
            total = 0;
            totalNumbers = 0;

        }
    }
}
