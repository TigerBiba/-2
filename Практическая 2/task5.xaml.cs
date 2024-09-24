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
    /// Логика взаимодействия для task5.xaml
    /// </summary>
    public partial class task5 : Window
    {
        public task5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int n = -1;
            int m = -1;
            int.TryParse(tbN.Text, out n);
            int.TryParse(tbM.Text, out m);
            if (n <= 0 || m <= 0)
                return;

            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            int max = -11;
            int min = 11;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }

            int[] flatMatrix = matrix.Cast<int>().ToArray();

            int[] ascended = flatMatrix.OrderBy(x => x).ToArray();
            int[] descended = flatMatrix.OrderByDescending(x => x).ToArray();

            string ascendedString = "";
            string descendingString = "";
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ascendedString += ascended[index] + "  ";
                    descendingString += descended[index] + "  ";
                    index++;
                }
                ascendedString += "\n";
                descendingString += "\n";
            }

            tblAcsended.Text = ascendedString;
            tblDescending.Text = descendingString;
            tblMax.Text = "Максимальный элемент массива: " + max;
            tblMin.Text = "Минимальный элемент массива: " + min;
        }
        
    }
}
