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

namespace Практическая_2
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
            task1 task1 = new task1();
            task1.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            task2 task2 = new task2();
            task2.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            task3 task3 = new task3();
            task3.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            task4 task4 = new task4();
            task4.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            task5 task5 = new task5();
            task5.Show();
            this.Hide();
        }
    }
}
