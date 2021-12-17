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

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ClickerTest : Window
    {
        public ClickerTest()
        {
            InitializeComponent();
        }

        long point = 110; // для поинт
        static int click = 1; // для поинт пер клик
        double sol_b1 = 10 + 10 * (30 + click * 0.2); // для расчета стоимости улучшения
                                                      // количества очков за нажатие
        double sol_b2 = 20 + 20 * (60 + click * 0.4);

        double sol_b3 = 30 + 30 * (60 + click * 0.4);

        double sol_b4 = 40 + 40 * (60 + click * 0.4);

        public void Update()
        {
            poi.Content = "Points: " + point; // Вывод Points в первый label
            cli.Content = "Points for click: " + click; // Вывод Points per click во второй label
            b1.Content = sol_b1.ToString();
            b2.Content = sol_b2.ToString();// Вывод цены Upgrade для Points per click на кнопке 
            b3.Content = sol_b3.ToString();
            b4.Content = sol_b4.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (point >= sol_b1)
            {
                point -= Convert.ToInt64(Math.Round(sol_b1));
                click += 3;
                Update();
            }
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += click;
            Update();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= sol_b2)
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                click += 7;
                Update();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= sol_b3)
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                click += 11;
                Update();
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (point >= sol_b4)
            {
                point -= Convert.ToInt64(Math.Round(sol_b4));
                click += 15;
                Update();
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}