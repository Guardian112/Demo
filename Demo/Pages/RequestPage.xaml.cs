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

namespace Demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        public RequestPage()
        {
            InitializeComponent();
            DataRequest.ItemsSource = Singleton.demoEntities.Zaiavka.ToList();
        }

        private void backToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToLogin = MainWindow.GetWindow(this) as MainWindow;
            backToLogin.Frame.Navigate(new LogIn());
        }
    }
}