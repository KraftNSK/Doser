using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Doser.Utility;
using Doser.Views;

namespace Doser.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenProductsCommand { get; set; }
        public ICommand OpenConfigActiveBunkersCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenProductsCommand = new RelayCommand(OpenProducts);
            OpenConfigActiveBunkersCommand = new RelayCommand(OpenConfigActiveBunkers);
        }

        private void OpenProducts(object p)
        {
            ShowChildWindow(new CatalogProductsWindowViewModel(), Type.GetType((string)p));
        }

        private void OpenConfigActiveBunkers(object p)
        {
            ShowChildWindow(new ConfigActiveBunkersWindowViewModel(), Type.GetType((string)p));
        }


    }
}
