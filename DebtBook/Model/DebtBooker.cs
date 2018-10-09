using System.Collections.Generic;
using DebtBook.Model.Entity;

namespace DebtBook.Model
{
    public class DebtBooker
    {
        public List<Debtor> Debtors { get; set; }
        
        public DebtBooker()
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