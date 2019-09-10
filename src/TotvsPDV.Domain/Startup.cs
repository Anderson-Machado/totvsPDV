using Microsoft.Extensions.DependencyInjection;
using TotvsPDV.Domain.Defaults;

namespace TotvsPDV.Domain
{
  public static class Startup
  {
    public static IServiceCollection AddPayrollManagement(this IServiceCollection services)
    {
      services.AddScoped<CalculationPDV>();

      return services;
    }

  }
}
