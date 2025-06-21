using FinanseWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanseWebApp.Data
{
    public class FinanseAppCtx : DbContext
    {
        public FinanseAppCtx(DbContextOptions<FinanseAppCtx> options) : base(options) { }   
        
        public DbSet<Expense> Expenses { get; set; }
        
    }
}
