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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //Numbers
        long num1 = 0;
        long num2 = 0;
        string op = "";
      public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (op=="")
            {
                num1 = (num1 * 10) + 1;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txt.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 2;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txt.Text = num2.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 3;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txt.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 4;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txt.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 5;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txt.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 6;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txt.Text = num2.ToString();
            }

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 7;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txt.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 8;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txt.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 9;
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txt.Text = num2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10);
                txt.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                txt.Text = num2.ToString();
            }
        }

        //Operators

        private void add_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            txt.Text = "0";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            txt.Text = "0";
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            txt.Text = "0";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            txt.Text = "0";
        }

        private void eql_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "+":
                    txt.Text = (num1 + num2).ToString();
                    break;

                case "-":
                    txt.Text = (num1 - num2).ToString();
                    break;

                case "*":
                    txt.Text = (num1 * num2).ToString();
                    break;

                case "/":
                    txt.Text = (num1 / num2).ToString();
                    break;

            }
        }

        //Clear all

        private void cln_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txt.Text = "0";
        }
    }
}
