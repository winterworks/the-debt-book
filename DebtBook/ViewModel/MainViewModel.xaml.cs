using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DebtBook.Model;
using DebtBook.Model.Entity;

namespace DebtBook.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        DebtBooker debtBooker = new DebtBooker();

        public List<Debtor> List { get { return debtBooker.Debtors; } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}