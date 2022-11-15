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
    /// Логика взаимодействия для Zadanie3.xaml
    /// </summary>
    public partial class Zadanie3 : Window
    {
        public Zadanie3()
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
            try
            {
                l_text2.Content = "Входной массив: ";
                l_text3.Content = "Выходной массив: ";
                l_text4.Content = "";
                bool res = int.TryParse(tb_volume.Text, out int n);
                if (!res)
                {
                    throw new Exception("Ошибка: ввод символов вместо цифр!");
                }
                Random rnd = new Random();
                int[] mas = new int[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i] = rnd.Next(1, 10);
                    l_text2.Content += Convert.ToString(mas[i]) + " ";
                }

                for (int i = 0; i < n; i++)
                {
                    if (i != 0 & i != n - 1 & mas[i] % 2 == 0)
                    {
                        mas[i] += mas[n - 1];
                    }
                    l_text3.Content += Convert.ToString(mas[i]) + " ";
                }
            }

            catch(Exception ex)
            {
                l_text4.Content = ex.Message;
            }
        }
    }
}
