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
            int[] array = GetArrayFromInput();

            List<int> seriesLengths = CalculateSeriesLengths(array);

            string result = string.Join(" ", seriesLengths);
            tblOtvet.Text = $"Длины серий: {result}";
        }
        private int[] GetArrayFromInput()
        {
            string inputString = tbNumber.Text.Trim();

            return inputString.Split(' ').Select(int.Parse).ToArray();
        }
        private List<int> CalculateSeriesLengths(int[] array)
        {
            List<int> seriesLengths = new List<int>();
            if (array.Length > 0)
            {
                int currentLength = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] == array[i - 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        seriesLengths.Add(currentLength);
                        currentLength = 1;
                    }
                }
                seriesLengths.Add(currentLength);
            }
            return seriesLengths;
        }
    }
}
