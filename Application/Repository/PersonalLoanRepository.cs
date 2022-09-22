using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public sealed class PersonalLoanRepository
    {
        private PersonalLoanRepository()
        {

        }

        public static PersonalLoanRepository Instance { get; } = new();
        public LoanListViewModel personalLoan = new();
    }
}
