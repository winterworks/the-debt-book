using System;

namespace DebtBook.Model.Entity
{
    public class Debt
    {
        private DateTime Date { get; set; }
        public string Value { get; }
        private string Description{ get; set; }

        public Debt(DateTime date, string value, string description)
        {
            this.Date = date;
            this.Value = value;
            this.Description = description;
        }
    }
}