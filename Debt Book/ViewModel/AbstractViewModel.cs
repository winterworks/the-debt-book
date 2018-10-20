using Debt_Book.View;
using Debt_Book.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private ICommand _cancel;
        public ICommand Cancel => _cancel ?? (_cancel = new RelayCommand(ExitWindow));

        protected abstract void ExitWindow();
    }
}
