using System.Windows.Input;
using Debt_Book.Model;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class AddDebtViewModel: AbstractViewModel
    {
        private readonly INavigationService ns;

        public AddDebtViewModel(INavigationService ns, DebtBook db) : base(ns, db){}
        
        protected override void ExitWindow()
        {
            _navService.CloseWindow(typeof(AddDebtViewModel));
        }
    }
}
