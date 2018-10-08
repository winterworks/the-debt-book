using System.Collections.Generic;
using DebtBook.Model.Entity;

namespace DebtBook.Model
{
    public class DebtBooker
    {
        public List<Person> DebtList { get; set; }

        public DebtBooker()
        {
            DebtList.Add(new Person("Henk", new List<Debt>()));
            DebtList.Add(new Person("Jannie", new List<Debt>()));
        }
    }
}