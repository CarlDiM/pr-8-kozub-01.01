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

namespace pr_8_kozub_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bus firstBus = new();
        Bus secondBus= new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createFirstBus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string brand = inputFirstBrand.Text;
                string model = inputFirstModel.Text;
                int capacity = Convert.ToInt32(inputFirstCapacity.Text);
                firstBus = new(brand, model, capacity);
                MessageBox.Show("Автобус создан", "Успех");
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Вместимость не может быть отрицательной", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проврьте введенные значения", "Ошибка");
            }
        }

        private void firstBusInformation_Click(object sender, RoutedEventArgs e)
        {
            if (firstBus.Brand != string.Empty)
            {
                string information = firstBus.BusInformation(firstBus);
                MessageBox.Show(information, "Информация");
            }
            else MessageBox.Show("Создайте автобус", "Ошибка");
        }

        private void createSecondBus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string brand = inputSecondBrand.Text;
                string model = inputSecondModel.Text;
                int capacity = Convert.ToInt32(inputSecondCapacity.Text);
                secondBus = new(brand, model, capacity);
                MessageBox.Show("Автобус создан", "Успех");
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Вместимость не может быть отрицательной", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проврьте введенные значения", "Ошибка");
            }
        }

        private void secondBusInformation_Click(object sender, RoutedEventArgs e)
        {
            if (secondBus.Brand != string.Empty)
            {
                string information = secondBus.BusInformation(firstBus);
                MessageBox.Show(information, "Информация");
            }
            else MessageBox.Show("Создайте автобус", "Ошибка");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №8\n" +
                "Козуб Дмитрий ИСП-34\n" +
                "Создать интерфейсы - автомобиль, пассажирский транспорт. Создать класс автобус. Класс должен включать конструктор, " +
                "функцию для формирования строки информации об автобусе. Сравнение производить по вместимости пассажиров.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void compare_Click(object sender, RoutedEventArgs e)
        {
            if (firstBus.Capacity != 0 && secondBus.Capacity != 0)
            {
                int compareResult = firstBus.CompareTo(secondBus);
                if (compareResult == 1)
                    MessageBox.Show("Первый вместительнее второго");
                if (compareResult == -1)
                    MessageBox.Show("Второй вмеcтительнее первого");
                if(compareResult == 0) MessageBox.Show("Автобусы по вместимости равны");
            }
            else MessageBox.Show("Нечего сравнивать", "Ошибка");
        }
    }
}
