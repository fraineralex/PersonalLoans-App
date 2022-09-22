using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using PersonalLoans_App.Models;
using System.Diagnostics;

namespace PersonalLoans_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonalLoanService _personalLoanService;

        public HomeController()
        {
            _personalLoanService = new PersonalLoanService();
        }

        public IActionResult Index()
        {
            return View(_personalLoanService.GetAll());
        }

        [HttpPost]
        public IActionResult CalculateLoan(LoanCreateViewModel vm)
        {
            _personalLoanService.Add(vm);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}