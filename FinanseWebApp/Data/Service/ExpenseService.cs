using FinanseWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanseWebApp.Data.Service
{
    public class ExpenseService : IExpensesService
    {
        private readonly FinanseAppCtx _ctx;
        public ExpenseService(FinanseAppCtx ctx)
        {
            _ctx = ctx;
        }
        public async Task Add(Expense expense)
        {
            _ctx.Expenses.Add(expense);
            await _ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _ctx.Expenses.ToListAsync();
            return expenses;
        }
    }
}
