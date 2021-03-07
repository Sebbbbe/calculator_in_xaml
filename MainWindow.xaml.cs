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
        double testing = 0;
        
        string operation = "";

        bool cOperatorClickTwice = false;
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
            testing = double.Parse(result.Text);
            
            operationPressed = false;
            cOperatorClickTwice = false;
        }

        private void operator_click(object sender, RoutedEventArgs e)

        {
            

         
            if (operation == "")
            {
                value += testing;
              
                
            }
            if (cOperatorClickTwice == false)
            {
                switch (operation)
                {

                    case "+":
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        value = double.Parse(result.Text);

                        break;
                    case "-":
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        value = double.Parse(result.Text);
                        break;
                    case "/":
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        value = double.Parse(result.Text);
                        break;
                    case "*":
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        value = double.Parse(result.Text);
                        break;
                    default:
                        break;
                }
            }
           


            Button b = (Button)sender;
            operation = Convert.ToString(b.Content);





            equation.Content = value + " " + operation;

            operationPressed = true;
            cOperatorClickTwice = true;





        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {

            operationPressed = false;
            equation.Content = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    
                    
                   
                  
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


        private void btnEqual()
        {
            operationPressed = false;
            equation.Content = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    value = Double.Parse(result.Text);
                    operation = "";
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
            operation = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0" ;
            value = 0;
            equation.Content = "";
            operation = "";
        }
    }
}