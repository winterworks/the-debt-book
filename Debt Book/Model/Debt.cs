﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debt_Book.Model
{
    class Debt
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public Debt(DateTime date, double value, string description)
        {
            this.Date = date;
            this.Value = value;
            this.Description = description;
        }
    }
}
