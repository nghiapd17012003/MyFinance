using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult ExpensesIndex()
        {
            return View();
        }
    }
}
