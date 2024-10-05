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
    /// Логика взаимодействия для task3.xaml
    /// </summary>
    public partial class task3 : Window
    {
        public task3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string arr = tbNumber.Text;
            string[] arrNumber = arr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            List<int> seriesLenght = new List<int>();

            int dup = 1;
            for(int i = 1;  i < arrNumber.Length; i++) 
            {
                if (arrNumber[i - 1] == arrNumber[i])
                {
                    dup++;
                }
                else 
                {
                    seriesLenght.Add(dup);
                    dup = 1;
                }
            }
            seriesLenght.Add(dup);

            tblOtvet.Text = "Длины серий: " + string.Join(" ", seriesLenght);
            
        }
    }
}
