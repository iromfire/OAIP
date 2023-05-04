
using System.Linq;

using System.Windows;


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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
