using Debt_Book.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Debt_Book.ViewModel
{
    class MainViewModel : AbstractViewModel
    {
        private Debtor _selectedDebtor;

        public MainViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}

        public ObservableCollection<Debtor> Debtors => _debtBook.Debtors;

        public Debtor SelectedDebtor
        {
            // solution inspired by http://stackoverflow.com/a/12297537
            get
            {
                return _selectedDebtor;
            }
            set
            {
                if(value == _selectedDebtor || value == null) return;
                _selectedDebtor = value;
                NotifyPropertyChanged();

                // Make an action when Debtor is clicked
                DebtorViewModel vm = ViewModelFactory.CreateDebtorViewModel();

                // set values to view model
                vm.SelectedDebtor = _selectedDebtor;

                _navService.OpenWindow(vm);
            }
        }
        
        private ICommand _openDebtorView;
        public ICommand OpenDebtorView => _openDebtorView ?? (_openDebtorView = new RelayCommand(NavigateToAddDebtorView));

        private void NavigateToAddDebtorView()
        {
            _navService.OpenWindow(ViewModelFactory.CreateAddDebtorViewModel());
            NotifyPropertyChanged(nameof(Debtors));
        }

        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(MainViewModel));
        }
    }
}
