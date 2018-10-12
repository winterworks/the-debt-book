using Debt_Book.Model;
using Debt_Book.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Debt_Book.ViewModel
{
    class MainViewModel: INotifyPropertyChanged
    {
        private readonly INavigationService ns;
        private Debtor _selectedDebtor;
        private DebtBook debtBook;
        public string Text { get; set; }
        public List<Debtor> debtors => debtBook.Debtors;

        public Debtor SelectedDebtor
        {
            get {
                return _selectedDebtor;
            }
            set
            {
                if(value == _selectedDebtor) return;
                _selectedDebtor = value;
                NotifyPropertyChanged();

                // 
                this.Text = "Loppkij";
                NotifyPropertyChanged("Text");
            }
        }

        public MainViewModel(INavigationService ns)
        {
            this.ns = ns;
            this.debtBook = new DebtBook();
            this.Text = "test";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
