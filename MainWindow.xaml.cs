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
     
        string operation = "";
       
        
        float number1 = 0;
        float total = 0;
        float totalNumbers;
        float decimalNumber = 0.1F;
        float x = 0.1F;
       
        bool isDecimal = false;
        bool isNegative = false;
      

        
        public MainWindow()
        {
            InitializeComponent();
        }
      
	


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            number1 = 1;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
            else
            {
                
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
           

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            number1 = 2;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
            else
            {
               
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            number1 = 3;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
          else 
            {
              
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            number1 = 4;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }

         else 
            {
             
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
          
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            number1 = 5;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }

           else 
            {
               
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
            
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            number1 = 6;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
         else
            {
              
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            number1 = 7;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
           else 
            {
                ;
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
            
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            number1 = 8;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
           else 
            {
              
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
         
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            number1 = 9;
            IsNegative();
            if (isDecimal == true)
            {
                IsDecimal();
            }
           else 
            {
                
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            if (isDecimal == true)
            {
                IsDecimal();
            }
          
            else  
            {
               
                total = (total * 10) + number1;
                txtBox.Text = total.ToString();
            }
           
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;
            txtBox.Text = "0";
            totalNumbers += total;
            total = 0;
            operation = "+";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;
            totalNumbers += total;
            txtBox.Text = "0";
            operation = "*";
            total = 0;


        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {


            isDecimal = false;
            isNegative = false;


            if (txtBox.Text == "0")
            {
                txtBox.Text = "-0";
                isNegative = true;
            }

           

            else
            {
                txtBox.Text = "0";
                totalNumbers += total;
                total = 0;
                operation = "-";
            }

        }

        private void btnDivided_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;
            totalNumbers += total;
            txtBox.Text = "0";
            operation = "/";
            total = 0;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;


            if (operation == "*")
            {
                txtBox.Text = (totalNumbers * total).ToString();
                totalNumbers *= total;
                total = 0;
            }

           else if (operation == "+")
            {
                txtBox.Text = (totalNumbers + total).ToString();
                totalNumbers += total;
                total = 0;
            }

            else if (operation == "/")
            {
                txtBox.Text = (totalNumbers / total).ToString();
                totalNumbers /= total;
                total = 0;
            }

            else if (operation == "-")
            {
                txtBox.Text = (totalNumbers - total).ToString();
                totalNumbers -= total;
                total = 0;
            }

        
        
          
            

        }

     

       
       
        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = total + ".";
            isDecimal = true;
        }


        private void IsDecimal()
        {


                decimalNumber = number1 * x;
               
                total += decimalNumber;
                 x *= 0.1F;
                 decimalNumber = 0.1F;
                 txtBox.Text = total.ToString();
 
        }

        private void IsNegative()
        {
            if (isNegative == true)
            {
                number1 = number1 * -1;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clears Everything
            total = 0;
            totalNumbers = 0;
            isDecimal = false;
            isNegative = false;
            operation = "";
            txtBox.Text = "0";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            //Clears everything on this action say 587 * 545 then it clears 545 only and 587 is still left

            total = 0;
            isDecimal = false;
            isNegative = false;
            txtBox.Text = "0";
        }

      
    }
}
