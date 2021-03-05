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
        public MainWindow()
        {
            InitializeComponent();
        }
      
	

        private void btn1_Click(object sender, RoutedEventArgs e)
        {


            total = (number1 * 10) + 1;
                txtBox.Text = number1.ToString();
       
        }

        
    }
}
