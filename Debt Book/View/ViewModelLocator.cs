using Debt_Book.Model;
using Debt_Book.ViewModel;

namespace Debt_Book.View
{
    class ViewModelLocator
    {
        static private readonly INavigationService ns = new NavigationService();

        static public MainViewModel MainViewModel => new MainViewModel(ns, DebtBook.Instance);
        static public DebtorViewModel DebtorViewModel => new DebtorViewModel(ns, DebtBook.Instance);
        static public AddDebtorViewModel AddDebtorViewModel => new AddDebtorViewModel(ns, DebtBook.Instance);
    }
}
