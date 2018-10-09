using System.Collections.Generic;

namespace DebtBook.Model.Entity
{
    public class Debtor
    {
        string _Name;
        public string Name { get
            {
                return _Name;
            }
        }
        public List<Debt> Debts { get; set; }

        public int calcDebt { get
            {
                int sumOfDebts = 0;
                foreach (Debt debt in Debts)
                {
                    sumOfDebts = int.Parse(debt.Value);
                }
                return sumOfDebts;
            }
        }

        public Debtor(string name)
        {
            this._Name = name;
            this.Debts = new List<Debt>();
        }

        public Debtor(string name, List<Debt> debtList)
        {
            this._Name = name;
            this.Debts = debtList;
        }
    }
}