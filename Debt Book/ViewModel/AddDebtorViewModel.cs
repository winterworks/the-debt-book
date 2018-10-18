using System.Windows.Input;
using Debt_Book.Model;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class AddDebtorViewModel: AbstractViewModel
    {
        private readonly INavigationService ns;

        public AddDebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db){}

        Debtor debtor = new Debtor("");

        public string Name
        {
            get => debtor.Name;
            set {
                if (value != debtor.Name) {
                    debtor.Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

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
            // save new debtor here
            _debtBook.AddDebtor(debtor);
            ExitWindow();
        }

        private bool SaveDebtorCanExecute()
        {
            return (Name != "");
        }
        
        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(AddDebtorViewModel));
        }
    }
}
