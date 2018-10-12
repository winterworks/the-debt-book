﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debt_Book.Model;
using Debt_Book.View;

namespace Debt_Book.ViewModel
{
    class AddDebtViewModel: AbstractViewModel
    {
        private readonly INavigationService ns;

        public AddDebtViewModel(INavigationService ns, DebtBook db) : base(ns, db){}
    }
}
