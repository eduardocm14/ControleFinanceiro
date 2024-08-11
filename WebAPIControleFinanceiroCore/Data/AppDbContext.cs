using Microsoft.EntityFrameworkCore;
using WebAPIControleFinanceiroCore.Model;

namespace WebAPIControleFinanceiroCore.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Conta> Contas { get; set; }
    }
}