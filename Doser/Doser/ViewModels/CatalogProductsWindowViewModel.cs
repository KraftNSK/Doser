using System.Collections.Generic;
using System.Collections.ObjectModel;
using Doser.Models;
using Doser.Utility;

namespace Doser.ViewModels
{
    public class CatalogProductsWindowViewModel: ViewModelBase
    {
        private readonly DBModel _context = new DBModel();

        private IEnumerable<Product> _products;
        public IEnumerable<Product> Products
        {
            get
            {
                return new ObservableCollection<Product>(_context.Products);
            }
            set
            {
                _products = value;
                RaisePropertyChangedEvent("Products");
            }
        } 

    }
}