using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel
    {
        private readonly INavigationService ns;

        public DebtorViewModel(INavigationService ns)
        {
            this.ns = ns;
        }
    }
}
