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
using System.Xml;
using CityLibrary;

namespace Practick5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private City city;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameLabel.Content = $"Город: {city.Name}, Число человек на 1 км²: {city.CalculatePopulationDensity()}, Число дней на посещение города: {city.CalculateDaysToVisitCity(int.Parse(attractionsPerDay_.Text))}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string Name;
                double Area;
                int Population;
                int GetTourDuration;
                Name = Name_.Text;
                Area = double.Parse(Area_.Text);
                Population = int.Parse(Population_.Text);
                GetTourDuration = int.Parse(GetTourDuration_.Text);

                city = new City(Name, Area, Population, GetTourDuration);

                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        


    }
}
