using Debt_Book.Model;
using Debt_Book.View;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Debt_Book.ViewModel
{
    class MainViewModel : AbstractViewModel
    {
        private Debtor _selectedDebtor;

        public MainViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}


        public ObservableCollection<Debtor> Debtors => _debtBook.Debtors;

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

                // Make an action when Debtor is clicked
                _navService.OpenWindow(typeof(DebtorViewModel));
                Messenger.Default.Send(_selectedDebtor);
            }
        }
        
        private ICommand _openDebtorView;
        public ICommand OpenDebtorView => _openDebtorView ?? (_openDebtorView = new RelayCommand(NavigateToOpenDebtorView));

        private void NavigateToOpenDebtorView()
        {
            _navService.OpenWindow(typeof(AddDebtViewModel));
            NotifyPropertyChanged(nameof(Debtors));
        }
    }
}
