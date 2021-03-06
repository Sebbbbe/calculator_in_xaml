using System.Windows;

namespace calculater_training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operation = "";

        private float number1 = 0;
        private float total = 0;
        private float totalNumbers;
        private float decimalNumber = 0.1F;
        private float x = 0.1F;

        private bool isDecimal = false;
        private bool isNegative = false;

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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
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
                ShowNumber();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;

            operation = "+";
            ResetTextBox();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;

            operation = "*";
            ResetTextBox();
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
                ResetTextBox();
                operation = "-";
            }
        }

        private void btnDivided_Click(object sender, RoutedEventArgs e)
        {
            isDecimal = false;
            isNegative = false;
            ResetTextBox();
            operation = "/";
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

        public void ShowNumber()
        {
            total = (total * 10) + number1;
            txtBox.Text = total.ToString();
        }

        public void ResetTextBox()
        {
            txtBox.Text = "0";
            totalNumbers += total;
            total = 0;
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