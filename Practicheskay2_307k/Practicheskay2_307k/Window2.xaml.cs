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
using System.Windows.Shapes;

namespace Practicheskay2_307k
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            //Lavle1.Visibility = Visibility.Hidden;
            Lavle2.Visibility = Visibility.Hidden;
            Lavle3.Visibility = Visibility.Hidden;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Lavle1.Visibility = Visibility.Visible;
            Lavle2.Visibility = Visibility.Hidden;
            Lavle3.Visibility = Visibility.Hidden;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Lavle1.Visibility = Visibility.Hidden;
            Lavle2.Visibility = Visibility.Visible;
            Lavle3.Visibility = Visibility.Hidden;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Lavle1.Visibility = Visibility.Hidden;
            Lavle2.Visibility = Visibility.Hidden;
            Lavle3.Visibility = Visibility.Visible;
        }
    }
}
