using System;
using System.Windows.Input;
using Debt_Book.Model;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel : AbstractViewModel
    {
        public Debtor SelectedDebtor { get; set; }

        private string _newDebtValue;
        private string _newDebtDescription;

        public DebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}

        public string NewDebtValue
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

        private ICommand _addDebt;
        public ICommand AddDebt
        {
            get { return _addDebt ?? (_addDebt = new RelayCommand(CreateNewDebt, CreateNewDebtCanExecute)); }
        }

        private void CreateNewDebt()
        {
            Debt debt = new Debt(DateTime.Now, double.Parse(NewDebtValue), NewDebtDescription);
            SelectedDebtor.AddDebt(debt);
            _debtBook.UpdateDebtor(SelectedDebtor);
        }

        private bool CreateNewDebtCanExecute()
        {
            bool EmptyFields = (NewDebtDescription == "" || NewDebtDescription == null
                    || NewDebtValue == "" || NewDebtValue == null);
            bool OnlyNumbers = double.TryParse(NewDebtValue, out double _);
            return !EmptyFields && OnlyNumbers;
        }

        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(DebtorViewModel));
        }
    }
}