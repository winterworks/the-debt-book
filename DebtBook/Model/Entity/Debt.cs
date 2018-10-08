using System;

namespace DebtBook.Model
{
    public class Debt
    {
        private DateTime Date { get; set; }
        private string Value { get; set; }
        private string Description{ get; set; }

        public Debt(DateTime date, string value, string description)
        {
            this.Date = date;
            this.Value = value;
            this.Description = description;
        }
    }
}