using Debt_Book.Model;
using Debt_Book.View;
using System.Collections.ObjectModel;
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
                DebtorViewModel vm = ViewModelLocator.DebtorViewModel;

                // set values to view model
                vm._selectedDebtor = _selectedDebtor;

                _navService.OpenWindow(vm);
            }
        }
        
        private ICommand _openDebtorView;
        public ICommand OpenDebtorView => _openDebtorView ?? (_openDebtorView = new RelayCommand(NavigateToOpenDebtorView));

        private void NavigateToOpenDebtorView()
        {
            _navService.OpenWindow(ViewModelLocator.AddDebtorViewModel);
            NotifyPropertyChanged(nameof(Debtors));
        }

        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(MainViewModel));
        }
    }
}
