using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TotvsPDV.Application.Defaults;
using TotvsPDV.Domain.Interfaces.Services;
using TotvsPDV.Domain.Service;
using TotvsPDV.Infra.Data;

namespace TotvsPDV.Application
{
  public static class Startup
  {
    public static IServiceCollection AddApplicationIoC(this IServiceCollection services)
    {
      services.AddScoped<IMoedasService, MoedasService>()
              .AddScoped<INotasService, NotasService>()
              .AddInfraDataIoC();

      services.AddScoped<Calculation>();

      services.AddAutoMapper(typeof(Startup));

      return services;
    }
  }
}
