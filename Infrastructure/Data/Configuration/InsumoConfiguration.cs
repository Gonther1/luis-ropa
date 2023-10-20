using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("Insumo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex(p => p.Nombre).IsUnique(); // Si estoy

        builder.Property(p => p.ValorUnit)
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.StockMin)
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.StockMax)
        .HasColumnType("int")
        .IsRequired();
    }
}
