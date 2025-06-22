using FinanseWebApp.Data;
using FinanseWebApp.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _ctx.Expenses.Add(expense);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
