using System;

namespace Debt_Book.ViewModel
{
    interface INavigationService
    {

        void OpenWindow(ViewModel.AbstractViewModel vm);
        void CloseWindow(Type vm);

    }
}
