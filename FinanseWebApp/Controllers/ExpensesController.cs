using FinanseWebApp.Data;
using FinanseWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanseWebApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly FinanseAppCtx _ctx;
        public ExpensesController(FinanseAppCtx ctx)
        {
            _ctx = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var expenses = await _ctx.Expenses.ToListAsync();
            return View(expenses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _ctx.Expenses.Add(expense);
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
