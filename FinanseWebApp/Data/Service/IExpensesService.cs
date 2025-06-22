using FinanseWebApp.Models;

namespace FinanseWebApp.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
    }
}
