using System.Collections.Generic;

namespace DebtBook.Model
{
    public class DebtBook
    {
        private List<Person> DebtList { get; set; }

        public DebtBook(List<Person> debtList)
        {
            DebtList = debtList;
        }
    }
}