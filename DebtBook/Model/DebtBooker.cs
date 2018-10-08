using System.Collections.Generic;
using DebtBook.Model.Entity;

namespace DebtBook.Model
{
    public class DebtBooker
    {
        public List<Person> DebtList { get; set; }

        public DebtBooker()
        {
            DebtList = new List<Person>();
            DebtList.Add(new Person("Henk"));
            DebtList.Add(new Person("Jannie"));
        }
    }
}