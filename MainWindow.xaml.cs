using MySql.Data.MySqlClient;
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

namespace warehouse1122
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NewProduct_Click(object sender, RoutedEventArgs e)
        {
            NewProductWindow newProductWindow = new NewProductWindow();
            this.Hide();
            newProductWindow.ShowDialog();
            this.Show();
        }

        private void SupplierButton_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow supplierWindow = new SupplierWindow();
            this.Hide();
            supplierWindow.ShowDialog();
            this.Show();
        }

        private void ProductChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ProductChangeWindow productChangeWindow = new ProductChangeWindow();
            this.Hide();
            productChangeWindow.ShowDialog();
            this.Show();
        }
    }
}
