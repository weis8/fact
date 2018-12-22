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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmFact(object sender, RoutedEventArgs e)
        {
            int num;
            bool var = int.TryParse(TB1.Text, out num);
            if (var)
            {
                int k = int.Parse(TB1.Text);
                int m = 1;
                for (int i = 1; i < k + 1; i++)
                {
                    m = m * i;
                }
                MessageBox.Show("Считаю факториал!");
                TB2.Text = TB1.Text + "! = " +m;
            }
            else
            {
                TB2.Text = "Число не введено!";
            }
        }

        private void cmEnter(object sender, MouseEventArgs e)
        {
            BT1.Content = "Факториал считается...";
        }

        private void cmLeave(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}