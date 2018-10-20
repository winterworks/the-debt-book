using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Debt_Book.Model
{
    // This thread safe singleton implementation was inspired by http://csharpindepth.com/Articles/General/Singleton.aspx

    class DebtBook
    {

        private static DebtBook instance;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static DebtBook()
        {
        }
        

        public static DebtBook Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DebtBook();
                }
                return instance;
            }
        }


        public ObservableCollection<Debtor> Debtors { get; }

        private DebtBook()
        {
            Debtors = new ObservableCollection<Debtor>();

            // mock data
            Debtor debtor = new Debtor("Henry");
            debtor.Debts.Add(new Debt(DateTime.Now, 12, "Submarine"));
            debtor.Debts.Add(new Debt(DateTime.Now, 5, "Milkshake"));
            AddDebtor(debtor);
            AddDebtor(new Debtor("Jane"));
        }

        public void AddDebtor(Debtor debtor)
        {
            Debtors.Add(debtor);
        }

        public void AddDebtTo(Debtor debtor, Debt debt)
        {
            if (!Debtors.Contains(debtor)) return;
            int index = Debtors.IndexOf(debtor);
            Debtors[index].Debts.Add(debt);
        }
    }
}
