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

            if (input.Length != 6 || !int.TryParse(input, out int number))
            {
                MessageBox.Show("Некорректный ввод. Введите шестизначное число.");
                return;
            }

            int firstDigit = int.Parse(input[0].ToString());
            int secondDigit = int.Parse(input[1].ToString());
            int thirdDigit = int.Parse(input[2].ToString());
            int fourthDigit = int.Parse(input[3].ToString());
            int fifthDigit = int.Parse(input[4].ToString());
            int sixthDigit = int.Parse(input[5].ToString());

            int sumFirstThree = firstDigit + secondDigit + thirdDigit;
            int sumLastThree = fourthDigit + fifthDigit + sixthDigit;

            if (sumFirstThree == sumLastThree)
            {
                tbnEnter.Text = "Сумма первых трех цифр равна сумме последних трех цифр.";
            }
            else
            {
                tbnEnter.Text = "Сумма первых трех цифр не равна сумме последних трех цифр.";
            }
        }
    }
}
