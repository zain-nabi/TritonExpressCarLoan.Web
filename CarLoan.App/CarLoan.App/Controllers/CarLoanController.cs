using Microsoft.AspNetCore.Mvc;

namespace CarLoan.App.Controllers
{
    public class CarLoanController : Controller
    {
        public IActionResult AllCarLoans()
        {
            return View();
        }
    }
}
