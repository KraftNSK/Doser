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
        private List<Window> _childWindows;

        public ICommand OpenProductsCommand { get; set; }
        public ICommand OpenConfigActiveBunkersCommand { get; set; }

        public MainWindowViewModel()
        {
            OpenProductsCommand = new RelayCommand(OpenProducts);
            OpenConfigActiveBunkersCommand = new RelayCommand(OpenConfigActiveBunkers);

            _childWindows = new List<Window>();
        }

        public void CloseAllChildWindow()
        {
            
            foreach (var w in _childWindows)
            {
                w.Closed -= WChilds_Closed;
                w.Close();
            }
            _childWindows.Clear();
        }

        private void OpenProducts(object p)
        {
            Type type = Type.GetType((string)p);
            if(!ViewIsOpen(type))
                AddChildWindow(ShowChildWindow(new CatalogProductsWindowViewModel(), type));
        }

        private void OpenConfigActiveBunkers(object p)
        {
            Type type = Type.GetType((string)p);
            if (!ViewIsOpen(type))
                AddChildWindow(ShowChildWindow(new ConfigActiveBunkersWindowViewModel(), type));
        }

        /// <summary>
        /// Призакрытии дочернего окна, удалять его из списка дочерних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WChilds_Closed(object sender, EventArgs e)
        {
            _childWindows.Remove((Window) sender);
        }

        /// <summary>
        /// Добавляет окно в список дочерних окон
        /// </summary>
        /// <param name="w"></param>
        private void AddChildWindow(Window w)
        {
            if (w != null)
            {
                _childWindows.Add(w);
                w.Closed += WChilds_Closed;
            }
        }

        /// <summary>
        /// Проверяет открыто ли окно конкретного View
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool ViewIsOpen(Type type)
        {
            if (_childWindows.Find(x => x.GetType() == type) != null)
            {
                MsgBox("");
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
