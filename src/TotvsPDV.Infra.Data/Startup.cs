using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TotvsPDV.Domain.Interfaces.Repositories;
using TotvsPDV.Infra.Data.Context;
using TotvsPDV.Infra.Data.Kernel.DBConfiguration;
using TotvsPDV.Infra.Data.Kernel.Interfaces;
using TotvsPDV.Infra.Data.Kernel.Repositories;
using TotvsPDV.Infra.Data.Repositories;

namespace TotvsPDV.Infra.Data
{
  public static class Startup
  {
    public static IConfiguration Configuration { get; private set; }

    public static IServiceCollection AddInfraDataIoC(this IServiceCollection services)
    {
      #region IoC dos Repositórios das classes de Entitdades
      services.AddScoped<INotasRepository, NotasRepository>();

      services.AddScoped<IMoedasRepository, MoedasRepository>();

      #endregion

      services.AddScoped<IRepositoryBaseDapper, RepositoryBaseDapper>();

      services.AddDbContext<TotvsDbContext>(options =>
          options.UseSqlServer(DatabaseConnection.ConnectionConfiguration.GetConnectionString("DbConnection")));

      return services;
    }
  }
}