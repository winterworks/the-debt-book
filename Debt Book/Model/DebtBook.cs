using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Debt_Book.Model
{
    // This thread safe singleton implemenattion was inspired by http://csharpindepth.com/Articles/General/Singleton.aspx

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
            AddDebtor(new Debtor("Henry"));
            AddDebtor(new Debtor("Jane"));
        }

        public void AddDebtor(Debtor debtor)
        {
            Debtors.Insert(0, debtor);
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
