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
        double tempValue = 0;
        
        string operation = "";

        bool cOperatorClickTwice = false;
        bool operationPressed = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

            
            if (result.Text =="0" || operationPressed == true  )
            {
                result.Clear();
               
            }


            
            
            
            Button b = (Button)sender;
            result.Text = result.Text + b.Content;
            tempValue = double.Parse(result.Text);
            
            operationPressed = false;
            cOperatorClickTwice = false;
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "0.";
            }
            else
            {
                result.Text = tempValue + ".";
            }

        }

        private void operator_click(object sender, RoutedEventArgs e)

        {
            

         
            if (operation == "")
            {
                value += tempValue;
              
                
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
            if (cOperatorClickTwice == false)
            {

                switch (operation)
                {
                    case "+":
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        value = Convert.ToDouble(result.Text);




                        break;
                    case "-":
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        value = Convert.ToDouble(result.Text);
                        break;
                    case "/":
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        value = Convert.ToDouble(result.Text);
                        break;
                    case "*":
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        value = Convert.ToDouble(result.Text);

                        break;

                    default:
                        break;

                }

            }

            cOperatorClickTwice = true;

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



            tempValue = 0;
           
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0" ;
            equation.Content = "";
            operation = "";
           
            value = 0;
            tempValue = 0;
         
           
           
        }

       
    }
}