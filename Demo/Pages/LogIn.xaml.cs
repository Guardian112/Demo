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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            Klient user = Singleton.demoEntities.Klient.FirstOrDefault(u=>u.Login==LoginBox.Text && u.Parol==PassBox.Password);
            if (user == null)
            {
                MessageBox.Show("Ничего не введено");
                return;
            }
            if (user.Role.Name == "admin") 
            {
                MainWindow goToRequestPage = MainWindow.GetWindow(this) as MainWindow;
                goToRequestPage.Frame.Navigate(new RequestPage());
            }
            if (user.Role.Name == "user")
            {
                MessageBox.Show("Вы зашли под пользователем");
                return;
            }
        }

        private void Regist(object sender, RoutedEventArgs e)
        {
            MainWindow goReg = MainWindow.GetWindow(this) as MainWindow;
            goReg.Frame.Navigate(new RegPage());
        }
    }
}
