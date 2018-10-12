using Debt_Book.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debt_Book.View
{
    interface INavigationService
    {
        void OpenWindow(Type vm);
        //void OpenWindow(Type vm, object arg);

    }
}
