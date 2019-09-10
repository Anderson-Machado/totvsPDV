using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TotvsPDV.Domain.Entities;

namespace TotvsPDV.Infra.Data.Mappings
{
  public class NotasMapping : IEntityTypeConfiguration<Notas>
  {
    public void Configure(EntityTypeBuilder<Notas> builder)
    {
      builder.ToTable("Notas");

      builder.HasKey(e => e.Id);
      builder.Property(e => e.Id).ValueGeneratedNever();


      builder.Property(e => e.Valor)
          .IsRequired().HasColumnType("decimal(18,2)");

    }
  }
}
