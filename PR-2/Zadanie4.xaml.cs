using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR_2
{
    /// <summary>
    /// Логика взаимодействия для Zadanie4.xaml
    /// </summary>
    public partial class Zadanie4 : Window
    {
        public Zadanie4()
        {
            InitializeComponent();
        }

        private void btn_back_Click_1(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            l_text2.Content = "Входной массив: ";
            l_text3.Content = "Выходной массив: ";
            Random rnd = new Random();
            int[] mas = new int[6];
            for (int i = 0; i < 6; i++)
            {
                mas[i] = rnd.Next(1, 10);
                l_text2.Content += Convert.ToString(mas[i]) + " ";
            }

            int m = mas[2];
            mas[2] = mas[4];
            mas[4] = m;

            for (int i = 0; i < 6; i++)
            {
                l_text3.Content += Convert.ToString(mas[i]) + " ";
            }
        }
    }
}
