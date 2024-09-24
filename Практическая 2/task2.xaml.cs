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
    /// Логика взаимодействия для task2.xaml
    /// </summary>
    public partial class task2 : Window
    {
        public task2()
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
            string inputText = tbText.Text;

            string processedText = string.Join(" ", inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            tblOtvet.Text = processedText;
        }
    }
}
