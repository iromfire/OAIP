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
using System.Windows.Shapes;

namespace OAIP
{
    /// <summary>
    /// Логика взаимодействия для Guest.xaml
    /// </summary>
    public partial class Guest : Window
    {
        public Guest()
        {
            InitializeComponent();
            using (var db = new OAIPEntities())
            {
                dataGrid3.ItemsSource = db.Product.ToList();
            }
        }

        private void dataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
