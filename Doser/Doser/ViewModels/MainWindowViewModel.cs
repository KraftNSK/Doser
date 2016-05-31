using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Doser.Utility;
using Doser.Views;

namespace Doser.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenProductsWindowCommand { get; set; }
        public ICommand OpenConfigActiveBunkersWindowCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenProductsWindowCommand = new RelayCommand(OpenProducts);
            OpenConfigActiveBunkersWindowCommand = new RelayCommand(OpenConfigActiveBunkers);
        }

        /// <summary>
        /// Открывает окно
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="view"></param>
        private void OpenWindow(ViewModelBase viewModel, object view)
        {
            Type type = Type.GetType((string)view);

            if (viewModel == null) throw new ArgumentNullException(nameof(viewModel));
            if (type == null) throw new ArgumentNullException(nameof(type));

            if (!ViewIsOpen(type))
                ShowChildWindow(viewModel, type);
        }

        private void OpenProducts(object p)
        {
            OpenWindow(new CatalogProductsWindowViewModel(), p);
        }

        private void OpenConfigActiveBunkers(object p)
        {
            OpenWindow(new ConfigActiveBunkersWindowViewModel(), p);
        }

        /// <summary>
        /// Проверяет открыто ли окно конкретного View
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool ViewIsOpen(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            if (Wnd.OwnedWindows.Cast<object>().Any(w => w.GetType() == type))
            {
                MessageBox.Show(this.Wnd,"Данное окно уже открыто!", "Сообщение", MessageBoxButton.OK);
                return true;
            }
            return false;
        }

        private void MsgBox(string msg)
        {
            ShowChildWindow(new MsgBoxWindowViewModel("Внимание!", "Данное окно уже открыто!"), Type.GetType("Doser.Views.MsgBoxWindow"), true);
        }

    }
}
