using System.Data.Entity;
using WindowsFormFinanceiro.Model;
using WindowsFormFinanceiro.Util;

public class AppDbContext : DbContext
{
    public AppDbContext() : base(GetConnectionString()) { }

    private static string GetConnectionString()
    {
        var iniFile = Utilitario.GetConfigBancoDadosINI();

        string server = iniFile.Read("DatabaseConfig", "Server");
        string database = iniFile.Read("DatabaseConfig", "Database");
        string user = iniFile.Read("DatabaseConfig", "User");
        string password = iniFile.Read("DatabaseConfig", "Password");

        return $"Host={server};Database={database};Username={user};Password={password}";
    }

    public DbSet<Conta> Contas { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("public");
    }
}
