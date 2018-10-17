using System;

namespace Debt_Book.View
{
    interface INavigationService
    {

        void OpenWindow(ViewModel.AbstractViewModel vm);
        void CloseWindow(Type vm);

    }
}
