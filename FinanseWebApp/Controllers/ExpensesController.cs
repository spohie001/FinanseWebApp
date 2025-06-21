using FinanseWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanseWebApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly FinanseAppCtx _ctx;
        public ExpensesController(FinanseAppCtx ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var expenses = _ctx.Expenses.ToList();
            return View(expenses);
        }
    }
}
