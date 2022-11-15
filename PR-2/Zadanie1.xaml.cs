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
    /// Логика взаимодействия для Zadanie1.xaml
    /// </summary>
    public partial class Zadanie1 : Window
    {
        public Zadanie1()
        {
            InitializeComponent();
        }
   
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_start_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                l_result.Foreground = new SolidColorBrush(Colors.Black);
                bool res = int.TryParse(tb_vvodChisla.Text, out int a);
                if (!res)
                {
                    throw new Exception("Ошибка: ввод символов вместо цифр");
                }

                if (a > 9999)
                {
                    throw new Exception("Ошибка: введено слишком большое число");
                }

                string[] text = { "однозначное число", "двухзначное число", "трехзначное число", "четырехзначное число" };

                if (a % 2 == 0)
                {
                    l_result.Content = "четное ";
                }
                else
                {
                    l_result.Content = "нечетное ";
                }

                l_result.Content += text[tb_vvodChisla.Text.Length - 1];
            }
            catch (Exception ex)
            {
                l_result.Foreground = new SolidColorBrush(Colors.Red);
                l_result.Content = ex.Message;
            }
        }
    }
}
