using Debt_Book.Model;
using Debt_Book.ViewModel;

namespace Debt_Book.View
{
    class ViewModelLocator
    {
        private readonly INavigationService ns = new NavigationService();
        private readonly DebtBook db = DebtBook.Instance;
        public MainViewModel MainViewModel => new MainViewModel(ns, db);
        public DebtorViewModel DebtorViewModel => new DebtorViewModel(ns, db);
        public AddDebtorViewModel AddDebtorViewModel => new AddDebtorViewModel(ns, db);
    }
}
