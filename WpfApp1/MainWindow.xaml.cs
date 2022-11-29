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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Добро пожаловать в ДОМ КНИГИ!");
            MainFrame.Navigate(new Katalog());
            Manager.MainFrame = MainFrame;
        }

        private void btnKatalog(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Kat();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Glavn(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = new Katalog();
        }

        private void Exet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мы будем рады видеть вас снова :)");
            Close();
        }

        private void Korzina(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Korzina();
        }
    }
}
