using Debt_Book.ViewModel;
using Debt_Book.Model;
using System.Windows.Input;

namespace Debt_Book.ViewModel
{
    class AddDebtorViewModel: AbstractViewModel
    {
        private string _debtorName;

        public string Name
        {
            get => _debtorName;
            set {
                    if (value != _debtorName) {
                    _debtorName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public AddDebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db) { }

        private ICommand _saveDebtorCommand;
        public ICommand SaveDebtorCommand
        {
            get {
                return _saveDebtorCommand ?? (_saveDebtorCommand =
                    new RelayCommand(SaveDebtor, SaveDebtorCanExecute));
            }
        }

        private void SaveDebtor()
        {
            Debtor debtor = new Debtor(_debtorName);
            _debtBook.AddDebtor(debtor);
            ExitWindow();
        }

        private bool SaveDebtorCanExecute()
        {
            return (Name != "" && Name != null);
        }
        
        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(AddDebtorViewModel));
        }
    }
}
