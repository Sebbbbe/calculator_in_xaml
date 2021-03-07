using System;
using System.Windows;
using System.Windows.Controls;

namespace calculater_training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        double value = 0;
        
        string operation = "";
        bool operationPressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text =="0" || operationPressed == true)
            {
                result.Clear();
               
            }

            Button b = (Button)sender;
            result.Text = result.Text + b.Content;
            operationPressed = false;

        }

        private void operator_click(object sender, RoutedEventArgs e)

        {
            Button b = (Button)sender;
            operation = (string)(b.Content);


            value = double.Parse(result.Text);
            operationPressed = true;
            equation.Content = value + " " + operation;

          



        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            operationPressed = false;
            equation.Content = "";
            switch (operation)
            {
                case "+":
                    result.Text =(value +Double.Parse(result.Text)).ToString(); 
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
                 
            }

        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
            equation.Content = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0" ;
            value = 0;
            equation.Content = "";
        }
    }
}