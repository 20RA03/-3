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

namespace ПР3
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

        private Array _myArray = new Array(3, 3);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rez.Text = _myArray.CountOfNumbers();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _myArray.Fill();
            dataGrid.ItemsSource = _myArray.ToDataTable().DefaultView;
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-34 Ржевский Александр. Дана матрица размера M × N. В каждом столбце матрицы найти максимальный элемент.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
