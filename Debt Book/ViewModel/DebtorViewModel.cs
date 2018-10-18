using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Debt_Book.Model;
using Debt_Book.View;
using GalaSoft.MvvmLight.Messaging;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel : AbstractViewModel
    {
        public Debtor _selectedDebtor { get; set; }

        private ObservableCollection<Debt> Debts;

        public DebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}

        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(DebtorViewModel));
        }
        
        Debt debt = new Debt(DateTime.Now, 0, "");
        public double newDebtValue
        {
            get => debt.Value;
            set {
                if (value != debt.Value) {
                    debt.Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string newDebtDescription
        {
            get => debt.Description;
            set {
                if (value != debt.Description) {
                    debt.Description = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private ICommand _addDebt;

        public ICommand AddDebt
        {
            get { return _addDebt ?? (_addDebt = new RelayCommand(createNewDebt)); }
        }

        private void createNewDebt()
        {
            _selectedDebtor.Debts.Add(debt);
        }
    }
}