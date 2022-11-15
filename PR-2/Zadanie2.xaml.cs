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
using System.Text.RegularExpressions;

namespace PR_2
{
    /// <summary>
    /// Логика взаимодействия для Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void btn_back_Click_1(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_start_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string text = tb_vvodStroki.Text.ToLower();
                Regex pattern = new Regex(@"[abcdefghijklmnopqrstuvwxyz]");
                if (pattern.IsMatch(text))
                {
                    throw new Exception("Ошибка: ввод предложения на английском языке");
                }
                int sum = 0;
                for (int x = 0; x < text.Length; x++)
                {
                    if (text[x] == 'а' || text[x] == 'е' || text[x] == 'ё' || text[x] == 'и' || text[x] == 'о' || text[x] == 'у' || text[x] == 'ы' || text[x] == 'э' || text[x] == 'ю' || text[x] == 'я')
                    {
                        sum += 1;
                    }
                }
                l_result.Content = "Количество гласных букв: " + sum;
            }
            catch (Exception ex)
            {
                l_result.Content = ex.Message;
            }
        }
    }
}
