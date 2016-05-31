using System;
using System.ComponentModel;
using System.Windows;
using Doser.Views;
using IDoser;

namespace Doser.Utility
{
    public abstract class ViewModelBase: INotifyPropertyChanged
    {
        public string Name;
        public Window Wnd { get; set; }

        protected Window ShowChildWindow(ViewModelBase viewModel, Type classNameWindow, bool isModal = false)
        {

            viewModel.Wnd = Activator.CreateInstance(classNameWindow) as Window;
            if (viewModel.Wnd == null) return null;
            viewModel.Wnd.DataContext = viewModel;
            viewModel.Wnd.Owner = this.Wnd;
            if (isModal)
            {
                viewModel.Wnd.ShowDialog();
                return null;
            }
            viewModel.Wnd.Show();
            return viewModel.Wnd;
        }

        #region INotifyPropertyChanged Members

            public event
            PropertyChangedEventHandler PropertyChanged;

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