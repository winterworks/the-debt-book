using Debt_Book.Model;
using Debt_Book.View;
using GalaSoft.MvvmLight.Messaging;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel: AbstractViewModel
    {
        public Debtor _selectedDebtor { get; set; }

        public DebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db) {}
        
        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(DebtorViewModel));
        }
    }
}
