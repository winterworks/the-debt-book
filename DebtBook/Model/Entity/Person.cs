using System.Collections.Generic;

namespace DebtBook.Model
{
    public class Person
    {
        private string Name { get; set; }
        private List<Debt> DebtList { get; set; }

        public Person(string name, List<Debt> debtList)
        {
            this.Name = name;
            this.DebtList = debtList;
        }
    }
}