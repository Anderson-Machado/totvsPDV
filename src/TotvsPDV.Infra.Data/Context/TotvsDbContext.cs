using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TotvsPDV.Domain.Entities;
using TotvsPDV.Infra.Data.Kernel.DBConfiguration;

namespace TotvsPDV.Infra.Data.Context
{
  public class TotvsDbContext : DbContext
  {
    public DbSet<Notas> Notas { get; set; }
    public DbSet<Moedas> Moedas { get; set; }
    //public DbSet<MovimentoConta> MovimentoContas { get; set; }

   
    /// <summary>
    /// Creating DatabaseContext without Dependency Injection 
    /// </summary>
    protected TotvsDbContext() { }

    /// <summary>
    /// Creating DatabaseContext configured by Dependency Injection 
    /// </summary>
    /// <param name="options"></param>
    public TotvsDbContext(DbContextOptions<TotvsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
      if (!dbContextOptionsBuilder.IsConfigured)
      {
        dbContextOptionsBuilder.UseSqlServer(
            DatabaseConnection.ConnectionConfiguration.GetConnectionString("DbConnection"));
      }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      ContextMapping.AddMap(modelBuilder);
    }
   
  }
}
