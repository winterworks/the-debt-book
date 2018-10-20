using System;
using System.Windows.Input;
using Debt_Book.Model;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel : AbstractViewModel
    {
        public Debtor SelectedDebtor { get; set; }

        private double _newDebtValue = 0.0;
        private string _newDebtDescription;

        public DebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}

        public double NewDebtValue
        {
            get => _newDebtValue;
            set
            {
                if (value != _newDebtValue)
                {
                    _newDebtValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NewDebtDescription
        {
            get => _newDebtDescription;
            set
            {
                if (value != _newDebtDescription)
                {
                    _newDebtDescription = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double DebtSum { get => SelectedDebtor.DebtSum; }

        private ICommand _addDebt;
        public ICommand AddDebt
        {
            get { return _addDebt ?? (_addDebt = new RelayCommand(CreateNewDebt, CreateNewDebtCanExecute)); }
        }

        private void CreateNewDebt()
        {
            Debt debt = new Debt(DateTime.Now, NewDebtValue, NewDebtDescription);
            SelectedDebtor.AddDebt(debt);
            _debtBook.UpdateDebtor(SelectedDebtor);
            NotifyPropertyChanged(nameof(DebtSum));
            NewDebtDescription = "";
            NewDebtValue = 0.0;
        }

        private bool CreateNewDebtCanExecute()
        {
            bool EmptyFields = (NewDebtDescription == "" || NewDebtDescription == null
                    || NewDebtValue == 0.0 || NewDebtValue == null);
            return !EmptyFields;
        }

        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(DebtorViewModel));
        }
    }
}