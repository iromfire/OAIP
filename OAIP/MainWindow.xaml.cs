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

namespace OAIP
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new OAIPEntities())
            {
                if (db.User.Any(u => u.UserLogin == UsernameTextbox.Text && u.UserPassword == PasswordBox.Text))
                {
                    User user = (from u in db.User where u.UserLogin == UsernameTextbox.Text select u).FirstOrDefault();
                    if (user.RoleID == 1)
                    {
                        new Goods().Show();
                        Close();
                    }
                    if (user.RoleID == 2)
                    {
                        new Admin().Show();
                        Close();
                    }
                    if (user.RoleID == 3)
                        new Manager().Show();
                        Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }

            }
        }

        private void LoginGuestButton_Click(object sender, RoutedEventArgs e)
        {
            new Guest().Show();
            Close();
        }
    }
}

  
    


