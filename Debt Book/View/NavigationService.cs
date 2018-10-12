using System;
using System.Windows;

namespace Debt_Book.View
{
    class NavigationService : INavigationService
    {
        public void OpenWindow(Type vm)
        {
            Window window = null;
            switch(vm.Name)
            {
                case "MainViewModel":
                    window = new MainView();
                    break;
                case "DebtorViewModel":
                    window = new DebtorView();
                    break;
                case "AddDebtViewModel":
                    window = new AddDebtView();
                    break;
            }
            if (window != null) window.ShowDialog();
        }
    }
}
