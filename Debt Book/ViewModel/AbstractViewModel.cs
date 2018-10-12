using Debt_Book.Model;
using Debt_Book.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Debt_Book.ViewModel
{
    abstract class AbstractViewModel: INotifyPropertyChanged
    {
        protected readonly INavigationService _navService;
        protected readonly DebtBook _debtBook;

        public AbstractViewModel(INavigationService ns, DebtBook db)
        {
            this._navService = ns;
            this._debtBook = db;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
