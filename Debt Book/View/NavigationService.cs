using System;
using System.Collections.Generic;
using System.Windows;

namespace Debt_Book.View
{
    class NavigationService : INavigationService
    {
        private Dictionary<string,Window> activeWindows = new Dictionary<string, Window>();
        
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
                case "AddDebtorViewModel":
                    window = new AddDebtorView();
                    break;
            }

            if (window == null) return;
            if (activeWindows.ContainsKey(vm.Name)) activeWindows.Remove(vm.Name);
            activeWindows.Add(vm.Name, window);
            window.ShowDialog();
        }
        
        public void CloseWindow(Type vm)
        {
            if (!activeWindows.ContainsKey(vm.Name)) return;
            activeWindows[vm.Name].Close();
            activeWindows.Remove(vm.Name);
        }
    }
}
