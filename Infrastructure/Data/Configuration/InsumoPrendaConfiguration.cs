using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
{
    public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
    {
        builder.ToTable("InsumoPrenda");
        builder.HasKey(e => e.IdInsumo);
        builder.Property(e => e.IdInsumo);
        builder.HasKey(e => e.IdPrenda);
        builder.Property(e => e.IdPrenda);
        
        builder.Property(p => p.Cantidad)
        .HasColumnType("int")
        .IsRequired();

        builder.HasOne(p => p.Insumos)
        .WithMany(p => p.InsumosPrendas)
        .HasForeignKey(p => p.IdInsumo);

        builder.HasOne(p => p.Prendas)
        .WithMany(p => p.InsumosPrendas)
        .HasForeignKey(p => p.IdPrenda);
    }
}
