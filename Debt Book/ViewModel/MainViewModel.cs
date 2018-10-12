using Debt_Book.Model;
using Debt_Book.View;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Debt_Book.ViewModel
{
    class MainViewModel: AbstractViewModel
    {
        private Debtor _selectedDebtor;

        public MainViewModel(INavigationService ns, DebtBook db) : base(ns, db){}

        public List<Debtor> Debtors => _debtBook.Debtors;

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

    }
}
