using System;

namespace Debt_Book.View
{
    interface INavigationService
    {
        void OpenWindow(Type vm);
        void CloseWindow(Type vm);

    }
}
