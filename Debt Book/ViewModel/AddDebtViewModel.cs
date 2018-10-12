using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class AddDebtViewModel
    {
        private readonly INavigationService ns;

        public AddDebtViewModel(INavigationService ns)
        {
            this.ns = ns;
        }
    }
}
