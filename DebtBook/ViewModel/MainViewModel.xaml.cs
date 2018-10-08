using System.Collections.Generic;
using DebtBook.Model;
using DebtBook.Model.Entity;

namespace DebtBook.ViewModel
{
    public class MainViewModel
    {

        public List<Person> List { get; set; }

        public MainViewModel()
        {
            var debtBooker = new DebtBooker();
            List = debtBooker.DebtList;
        }
    }

}