using Microsoft.EntityFrameworkCore;
using WebAPIControleFinanceiroCore.Model;

namespace WebAPIControleFinanceiroCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<ContratoAluguel> ContratosAlugueis { get; set; }
    }
}
