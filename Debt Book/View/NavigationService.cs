using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Debt_Book.Model;
using Debt_Book.ViewModel;

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
