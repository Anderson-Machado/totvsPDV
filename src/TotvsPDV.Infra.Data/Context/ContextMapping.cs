using Microsoft.EntityFrameworkCore;
using TotvsPDV.Infra.Data.Mappings;

namespace TotvsPDV.Infra.Data.Context
{
  internal class ContextMapping
  {
    public static void AddMap(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new NotasMapping());
      modelBuilder.ApplyConfiguration(new MoedasMapping());
    }
  }
}
