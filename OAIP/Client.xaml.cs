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
    /// Логика взаимодействия для Goods.xaml
    /// </summary>
    public partial class Goods : Window
    {
    
        public Goods()
        {
            InitializeComponent();
            using (var db = new OAIPEntities())
            {
                dataGrid1.ItemsSource = db.Product.ToList();
            }
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Goods goods = new Goods();
            this.Close();
            goods.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    {
        //        switch (ComboBoxFilter.SelectedIndex)
        //        {
        //            case 0:
        //                {
        //                    using (var context = new OAIPEntities())
        //                    {
        //                        db.Products.List.ItemsSource = db context.Product.Where(p => p.ProductDiscountAmount < 10).ToList();
        //                    }
        //                    break;
        //                }
        //            case 1:
        //                {
        //                    using (var context = new OAIPEntities())
        //                    {
        //                        ListProducts.ItemsSource = context.Product.Where(p => p.ProductDiscountAmount > 10 && p.ProductDiscountAmount < 15).ToList();
        //                    }
        //                    break;
        //                }
        //            case 2:
        //                {
        //                    using (var context = new OAIPEntities())
        //                    {
        //                        ListProducts.ItemsSource = context.Product.Where(p => p.ProductDiscountAmount > 15).ToList();
        //                    }
        //                    break;
        //                }
        //            case 3:
        //                {
        //                    using (var context = new OAIPEntities())
        //                    {
        //                        ListProducts.ItemsSource = context.Products.ToList();
        //                    }
        //                    break;
        //                }
        //        }
        //    }
        //}
    }
}
