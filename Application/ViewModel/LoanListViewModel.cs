﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoanListViewModel
    {
        public List<MonthCuoteViewModel> LoanList { get; set; } = new();
    }
}
