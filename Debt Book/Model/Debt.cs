﻿using System;

namespace Debt_Book.Model
{
    class Debt
    {
        public DateTime Date { get; }
        public double Value { get; }
        public string Description { get; }
        public Debt(DateTime date, double value, string description)
        {
            this.Date = date;
            this.Value = value;
            this.Description = description;
        }
    }
}
