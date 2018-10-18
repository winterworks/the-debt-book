using System.Collections.ObjectModel;

namespace Debt_Book.Model
{
    class Debtor
    {
        public string Name { get; set; }
        public ObservableCollection<Debt> Debts { get; }

        public double DebtSum
        {
            get
            {
                double sumOfDebts = 0;
                foreach (Debt debt in Debts)
                {
                    sumOfDebts += debt.Value;
                }
                return sumOfDebts;
            }
        }

        public Debtor(string name)
        {
            this.Name = name;
            this.Debts = new ObservableCollection<Debt>();
        }

        public Debtor(string name, ObservableCollection<Debt> debtList)
        {
            this.Name = name;
            this.Debts = debtList;
        }
    }
}
