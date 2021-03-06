﻿using System.Windows;

namespace Debt_Book
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Window win = new MainView();
            win.DataContext = ViewModel.ViewModelFactory.CreateMainViewModel();
            win.Show();
        }
    }
}
