using Debt_Book.Model;
using Debt_Book.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Debt_Book.ViewModel
{
    class MainViewModel: INotifyPropertyChanged
    {
        private readonly INavigationService navService;
        private Debtor _selectedDebtor;
        private DebtBook debtBook;
        public List<Debtor> Debtors => debtBook.Debtors;

        public Debtor SelectedDebtor
        // solution inspired by http://stackoverflow.com/a/12297537
        {
            get {
                return _selectedDebtor;
            }
            set
            {
                if(value == _selectedDebtor) return;
                _selectedDebtor = value;
                NotifyPropertyChanged();

                // Make an action when debtor is clicked

            }
        }

        public MainViewModel(INavigationService ns, DebtBook db)
        {
            this.navService = ns;
            this.debtBook = db;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
