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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void BackToLogin(object sender, RoutedEventArgs e)
        {
            MainWindow backToLogin = MainWindow.GetWindow(this) as MainWindow;
            backToLogin.Frame.Navigate(new LogIn());
        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            Klient employe = Singleton.demoEntities.Klient.Add(new Klient()
            {
                Ima = Ima.Text,
                Familia = Familia.Text,
                Otchestvo = Otchestvo.Text,
                Login = Login.Text,
                Parol = Parol.Password,
                RoleID = 2,
            });
            Singleton.demoEntities.SaveChanges();
            MessageBox.Show("Пользователь зарегистрирован");
            MainWindow backToLogin = MainWindow.GetWindow(this) as MainWindow;
            backToLogin.Frame.Navigate(new LogIn());
        }
    }
}