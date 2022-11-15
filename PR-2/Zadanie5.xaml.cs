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
    /// Логика взаимодействия для Zadanie5.xaml
    /// </summary>
    public partial class Zadanie5 : Window
    {
        public Zadanie5()
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
                l_textError.Foreground = new SolidColorBrush(Colors.Black);
                l_text3.Content = "";
                l_text4.Content = "";
                l_text5.Content = "";
                bool res1 = int.TryParse(tb_n.Text, out int n);
                bool res2 = int.TryParse(tb_m.Text, out int m);
                int min = 10;
                int max = -10;
                string indexMin = "";
                string indexMax = "";

                if (!res1 || !res2)
                {
                    throw new Exception("Ошибка: ввод символов вместо цифр!");
                }
                if (n <= 0 || m <= 0)
                {
                    throw new Exception("Ошибка: введите неотрицательное число больше нуля");
                }
                Random rnd = new Random();
                int[,] mas = new int[n, m];
                int[] mas1 = new int[n * m];

                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = rnd.Next(-10, 11);

                        if (mas[i, j] < min)
                        {
                            min = mas[i, j];
                            indexMin = $"{i},{j}";
                        }
                        if (mas[i, j] > max)
                        {
                            max = mas[i, j];
                            indexMax = $"{i},{j}";
                        }

                        l_text3.Content += $"{mas[i, j]}\t";
                        mas1[index] = mas[i, j];
                        index++;
                    }
                    l_text3.Content += "\n";
                }
                l_textError.Content = $"Максимальный элемент: {max}, его индекс {indexMax}\nМинимальный элемент: {min}, его индекс {indexMin}";
                Array.Sort(mas1);

                index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = mas1[index];
                        index++;
                        l_text4.Content += $"{mas[i, j]}\t";
                    }
                    l_text4.Content += "\n";
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = m - 1; j >= 0; j--)
                    {
                        l_text5.Content += $"{mas[i, j]}\t";
                    }
                    l_text5.Content += "\n";
                }

            }

            catch (Exception ex)
            {
                l_textError.Foreground = new SolidColorBrush(Colors.Red);
                l_textError.Content = ex.Message;
            }
        }
    }
}
