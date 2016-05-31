﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Doser.ViewModels;

namespace Doser
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = new MainWindow();
            var viewModel = new MainWindowViewModel {Wnd = mainWindow};
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }
}
