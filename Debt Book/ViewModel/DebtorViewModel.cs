using Debt_Book.Model;
using Debt_Book.View;
using GalaSoft.MvvmLight.Messaging;

namespace Debt_Book.ViewModel
{
    class DebtorViewModel: AbstractViewModel
    {
        private readonly INavigationService ns;
        public Debtor _selectedDebtor { get; set; }

        public DebtorViewModel(INavigationService ns, DebtBook db) : base(ns, db){
            Messenger.Default.Register<Debtor>(this, (debtor) =>
            {
                this._selectedDebtor = debtor;
            });
        }
        
        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(DebtorViewModel));
        }
    }
}
