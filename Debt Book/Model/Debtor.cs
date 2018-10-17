using System.Collections.Generic;

namespace Debt_Book.Model
{
    class Debtor
    {
        public string Name { get; set; }
        public List<Debt> Debts { get; }

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
            this.Debts = new List<Debt>();
        }

        public Debtor(string name, List<Debt> debtList)
        {
            this.Name = name;
            this.Debts = debtList;
        }
    }
}
