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
using Doser.Views;
using Doser.Models;

namespace Doser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public void Main()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var w = new Window();
            (new CatalogProductsView()).Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBModel db = new DBModel();
            var p = new Product {Name = "Otsev", Code = "200-1", TimeCreate = DateTime.Now};
            p.Code1c = "0";
            p.Description = "adfas";
            p.TimeDeleted = p.TimeCreate;
            
            var u = new User();
            u.Name = "petya";
            //u.TimeCreate = DateTime.Now;
            //u.TimeDeleted = DateTime.Now;

            p.UserCreate = u;
            db.Users.Add(u);
            db.Products.Add(p);
            db.SaveChanges();

        } 
    }
}
