using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OAIP
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        OAIPEntities db = new OAIPEntities();
        public ProductAdd()
        {
            InitializeComponent();
            cbManufacturer.ItemsSource = db.ProductManufacturer.ToList();
            cbCategory.ItemsSource = db.ProductCategory.ToList();
            cbUnitType.ItemsSource = db.UnitType.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Admin().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductArticleNumber = ArticleTextBox.Text,
                    ProductName = NameTextBox.Text,
                    ProductCategoryID = ((ProductCategory)(cbCategory.SelectedItem)).ProductCategoryID,
                    ProductQuantityInStock = Int32.Parse(Quantity.Text),
                    ProductManufacturerID = ((ProductManufacturer)(cbManufacturer.SelectedItem)).ProductManufacturerID,
                    UnitTypeID = ((UnitType)(cbUnitType.SelectedItem)).UnitTypeID,
                    ProductMaxDiscountAmount = Convert.ToByte(MaxSale.Text),
                    ProductDiscountAmount = Convert.ToByte(Sale.Text),
                    ProductCost = Convert.ToDecimal(PriceForOnce.Text),
                    ProductPhoto = "IMG",
                    ProductDescription = Info.Text,
                    ProductSupplierID = ((ProductManufacturer)(cbManufacturer.SelectedItem)).ProductManufacturerID,
                };
                db.Product.Add(product);
                db.SaveChanges();
                MessageBox.Show("Успешно!");
            }
            catch
            {
                MessageBox.Show("Некоторые поля не заполнены или заполнены неправильно!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
             
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
