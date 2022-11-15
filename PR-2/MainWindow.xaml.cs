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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_zadanie1_Click(object sender, RoutedEventArgs e)
        {
            Zadanie1 zadanie1 = new Zadanie1();
            zadanie1.Show();
            zadanie1.Owner = this;
            this.Hide();
        }

        private void btn_zadanie2_Click(object sender, RoutedEventArgs e)
        {
            Zadanie2 zadanie2 = new Zadanie2();
            zadanie2.Show();
            zadanie2.Owner = this;
            this.Hide();
        }

        private void btn_zadanie3_Click(object sender, RoutedEventArgs e)
        {
            Zadanie3 zadanie3 = new Zadanie3();
            zadanie3.Show();
            zadanie3.Owner = this;
            this.Hide();
        }

        private void btn_zadanie4_Click(object sender, RoutedEventArgs e)
        {
            Zadanie4 zadanie4 = new Zadanie4();
            zadanie4.Show();
            zadanie4.Owner = this;
            this.Hide();
        }

        private void btn_zadanie5_Click(object sender, RoutedEventArgs e)
        {
            Zadanie5 zadanie5 = new Zadanie5();
            zadanie5.Show();
            zadanie5.Owner = this;
            this.Hide();
        }
    }
}
