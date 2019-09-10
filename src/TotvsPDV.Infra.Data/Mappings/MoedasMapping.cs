using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TotvsPDV.Domain.Entities;

namespace TotvsPDV.Infra.Data.Mappings
{
  public class MoedasMapping : IEntityTypeConfiguration<Moedas>
  {
    public void Configure(EntityTypeBuilder<Moedas> builder)
    {
      builder.ToTable("Moedas");

      builder.HasKey(e => e.Id);

      builder.Property(e => e.Id).ValueGeneratedNever();

      builder.Property(e => e.Moeda)
          .IsRequired().HasColumnType("decimal(18,3)");

    }
  }
}
