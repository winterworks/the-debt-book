using System.Collections.Generic;

namespace Debt_Book.Model
{
    class DebtBook
    {
        public List<Debtor> Debtors { get; }

        public DebtBook()
        {
            Debtors = new List<Debtor>();

            // mock data
            AddDebtor("Henry");
            AddDebtor("Jane");
        }

        public void AddDebtor(string name)
        {
            Debtors.Add(new Debtor(name));
        }

        public void AddDebtTo(Debtor debtor, Debt debt)
        {
            /* 
             * TODO: Check if person is in the DebtList -> 
             * throw error if its not 
             */
            int index = Debtors.IndexOf(debtor);
            Debtors[index].Debts.Add(debt);
        }
    }
}
