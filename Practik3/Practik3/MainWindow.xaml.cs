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

namespace Practik3
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
            try
            {
                string i1 = TextBox1.Text;
                string i2 = TextBox2.Text;
                string operation = index.Text;
                float num1 = float.Parse(i1);
                float num2 = 0;

                if (operation != "!" && !string.IsNullOrEmpty(i2))
                {
                    num2 = float.Parse(i2);
                }

                switch (operation)
                {
                    case "+":
                        labelResult.Content = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        labelResult.Content = Convert.ToString(num1 - num2);
                        break;
                    case "*":
                        labelResult.Content = Convert.ToString(num1 * num2);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            labelResult.Content = Convert.ToString(num1 / num2);
                        }
                        else
                        {
                            labelResult.Content = "Ошибка: деление на 0";
                        }
                        break;
                    case "^":
                        labelResult.Content = Convert.ToString(Math.Pow(num1, num2));
                        break;
                    case "!":
                        if (num1 < 0 || num1 != Math.Floor(num1))
                        {
                            labelResult.Content = "Ошибка: факториал определён только для неотрицательных целых чисел";
                        }
                        else
                        {
                            labelResult.Content = Convert.ToString(Factorial((int)num1));
                        }
                        break;
                    default:
                        labelResult.Content = "Ошибка: неверная операция";
                        break;
                }
            }
            catch (FormatException)
            {
                labelResult.Content = "Ошибка: неверный формат числа";
            }
        }
        private int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
