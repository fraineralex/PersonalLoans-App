using Application.Enum;
using Application.Repository;
using Application.Struct;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PersonalLoanService
    {
        public void Add(LoanCreateViewModel vm)
        {
            int loanAmount = vm.LoanAmount;
            int loanType = vm.LoanType;
            int monthAmount = vm.MonthAmount;

            switch (loanType)
            {
                case (int)LoanType.Personal:
                    {
                        CalculateLoan(monthAmount, loanAmount, LoanCoutes.PersonalCuote);
                        break;
                    }
                case (int)LoanType.Automovil:
                    {
                        CalculateLoan(monthAmount, loanAmount, LoanCoutes.AutomovilCuote);
                        break;
                    }
                case (int)LoanType.Hipotecario:
                    {
                        CalculateLoan(monthAmount, loanAmount, LoanCoutes.HipotecarioCuote);
                        break;
                    }
            }
        }

        private void CalculateLoan(int monthAmount, int loanAmount, double interestRate)
        {
            switch (monthAmount)
            {
                case (int)LoanEnum.DoceMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 12, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.DiezYOchoMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 18, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.VeinteYCuatroMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 24, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.TreintaMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 30, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.TreintaYSeisMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 36, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CuarentaYDosMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 42, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CuarentaYOchoMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 48, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CincuentaYCuatroMeses:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 54, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.Seseinta:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 60, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.SeseintaYSeis:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 66, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.SetentaYDos:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 72, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.SetentaYOcho:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 78, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.OchentaYCuatro:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 84, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.Noventa:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 90, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.NoventaYSeis:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 96, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CientoDos:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 102, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CientoOcho:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 108, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CientoCatorce:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 114, 2) + " Monthly pesos" });
                        break;
                    }
                case (int)LoanEnum.CientoVeinte:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = Math.Round((loanAmount + (loanAmount * interestRate)) / 120, 2) + " Monthly pesos" });
                        break;
                    }
                default:
                    {
                        PersonalLoanRepository.Instance.personalLoan.LoanList.Add(new MonthCuoteViewModel { Result = "Chose a month amount" });
                        break;
                    }
            }
        }

        public LoanListViewModel GetAll()
        {
            return PersonalLoanRepository.Instance.personalLoan;
        }
    }
}
