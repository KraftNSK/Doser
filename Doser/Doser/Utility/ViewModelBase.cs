using System;
using System.ComponentModel;
using System.Windows;
using Doser.Views;

namespace Doser.Utility
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Дочернее окно
        /// </summary>
        private Window _wnd = null;

        /// 
        /// Методы вызываемый окном при закрытии
        /// 
        protected virtual void Closed()
        {
            if (_wnd == null) return;
            _wnd.Close();
            _wnd = null;
        }

        protected void ShowChildWindow(ViewModelBase viewModel, Type classNameWindow, bool isModal=false)
        {
            viewModel._wnd = Activator.CreateInstance(classNameWindow) as Window;
            if (viewModel._wnd == null) return;
            viewModel._wnd.DataContext = viewModel;
            viewModel._wnd.Closed += (sender, e) => Closed();
            if (isModal)
                viewModel._wnd.ShowDialog();
            else
                viewModel._wnd.Show();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Protected Methods

        /// <summary>
        /// Fires the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the changed property.</param>
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged == null) return;
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChanged(this, e);
        }

        #endregion
    }
}