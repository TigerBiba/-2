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
    /// Логика взаимодействия для task4.xaml
    /// </summary>
    public partial class task4 : Window
    {
        public task4()
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

            int maxNegativeIndex = FindMaxNegativeIndex(array);
            int minPositiveIndex = FindMinPositiveIndex(array);

            SwapElements(array, maxNegativeIndex, minPositiveIndex);

            string result = ($"Первый элемент равен {array[maxNegativeIndex]}, на позиции {maxNegativeIndex}, " + $"второй элемент равен {array[minPositiveIndex]}, на позиции {minPositiveIndex}.");

            tblOtvet.Text = $"Результат перестановки: {string.Join(" ", array) +  "\n" + result}";
        }
        private int[] GetArrayFromInput()
        {
            string inputString = tbArray.Text.Trim();

            return inputString.Split(' ').Select(int.Parse).ToArray();
        }

        private int FindMaxNegativeIndex(int[] array)
        {
            int maxNegative = 0;
            int maxNegativeIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && Math.Abs(array[i]) > Math.Abs(maxNegative))
                {
                    maxNegative = array[i];
                    maxNegativeIndex = i;
                }
            }
            return maxNegativeIndex;
        }

        private int FindMinPositiveIndex(int[] array)
        {
            int minPositive = int.MaxValue;
            int minPositiveIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minPositive)
                {
                    minPositive = array[i];
                    minPositiveIndex = i;
                }
            }
            return minPositiveIndex;
        }

        private void SwapElements(int[] array, int index1, int index2)
        {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
        }
    }
}
