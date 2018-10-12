using Debt_Book.ViewModel;

namespace Debt_Book.View
{
    class ViewModelLocator
    {
        private readonly INavigationService ns = new NavigationService();
        public MainViewModel MainViewModel => new MainViewModel(ns);
        public DebtorViewModel DebtorViewModel => new DebtorViewModel(ns);
        public AddDebtViewModel AddDebtViewModel => new AddDebtViewModel(ns);
    }
}
