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
using CityLibrary;

namespace Practick4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public City city = new City();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameLabel.Content = $"Title: {city.Title}, PopulationSize: {Convert.ToString(city.PopulationSize)}, Square: {city.Square}, NumberOfAttractions: {Convert.ToString(city.NumberOfAttractions)}, CostPerDay: {city.CostPerDay}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title.Text))
                {
                    MessageBox.Show("Введите название города.");
                    return;
                }
                city.Title = title.Text;

                if (!int.TryParse(population_size.Text, out int populationSize) || populationSize < 0)
                {
                    MessageBox.Show("Введите корректное числовое значение для размера населения.");
                    return;
                }
                city.PopulationSize = populationSize;

                if (!int.TryParse(square_.Text, out int square) || square < 0)
                {
                    MessageBox.Show("Введите площадь города.");
                    return;
                }
                city.Square = square;

                if (!int.TryParse(number_of_attractions.Text, out int attractions) || attractions < 0)
                {
                    MessageBox.Show("Введите корректное положительное число для количества достопримечательностей.");
                    return;
                }
                city.NumberOfAttractions = attractions;

                if (!int.TryParse(number_of_attractions.Text, out int cost_per_day) || cost_per_day < 0)
                {
                    MessageBox.Show("Введите стоимость проживания за день.");
                    return;
                }
                city.CostPerDay = cost_per_day;

                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }


    }
}
