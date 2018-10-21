using Debt_Book.Model;

namespace Debt_Book.ViewModel
{
    class ViewModelFactory
    {
        static private readonly INavigationService ns = new NavigationService();

        static public MainViewModel CreateMainViewModel() => new MainViewModel(ns, DebtBook.Instance);
        static public DebtorViewModel CreateDebtorViewModel() => new DebtorViewModel(ns, DebtBook.Instance);
        static public AddDebtorViewModel CreateAddDebtorViewModel() => new AddDebtorViewModel(ns, DebtBook.Instance);
    }
}
