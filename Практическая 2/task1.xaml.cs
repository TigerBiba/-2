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

namespace Практическая_2
{
    /// <summary>
    /// Логика взаимодействия для task1.xaml
    /// </summary>
    public partial class task1 : Window
    {
        public task1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnOtvet_Click(object sender, RoutedEventArgs e)
        {
            string input = tbNumber.Text;

            if (input.Length != 6)
            {
                MessageBox.Show("Некорректный ввод. Введите шестизначное число.");
                return;
            }

            char[] arr = input.ToCharArray();

            if (arr[0] + arr[1] + arr[2] == arr[3] + arr[4] + arr[5]) 
            { 
            tbnEnter.Text = "Первые три числа равны последним трём числам";
            } 
            else
            {
            tbnEnter.Text = "Первые три числа не равны последним трём числам";
            }
        }
    }
}
