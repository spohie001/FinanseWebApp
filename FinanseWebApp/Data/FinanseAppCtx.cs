using FinanseWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanseWebApp.Data
{
    public class FinanseAppCtx : DbContext
    {
        public FinanseAppCtx(DbContextOptions<FinanseAppCtx> options) : base(options) { }   
        
        DbSet<Expense> Expenses { get; set; }
        
    }
}
