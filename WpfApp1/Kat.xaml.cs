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
    /// Логика взаимодействия для Kat.xaml
    /// </summary>
    public partial class Kat : Page
    {
        public Kat()
        {
            InitializeComponent();
        }

        private void Kniga1(object sender, RoutedEventArgs e)
        {
            object tag = ((Button)e.OriginalSource).Tag;
            Manager.MainFrame.Navigate(new Kniga1());   //Не работает
        }

        private void Bercerk(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kniga1.xaml", UriKind.Relative));
        }
    }
}
