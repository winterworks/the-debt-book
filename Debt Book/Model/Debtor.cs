using System.Collections.ObjectModel;

namespace Debt_Book.Model
{
    class Debtor
    {
        public string Name { get; }
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

        public void AddDebt(Debt debt)
        {
            Debts.Add(debt);
        }
    }
}
