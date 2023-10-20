using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{

    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventario");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.CodInv)
        .HasColumnType("int")
        .IsRequired();

        builder.HasIndex(p => p.CodInv)
        .IsUnique();  // Si estoy

        builder.Property(p => p.ValorVtaCop)
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.ValorVtaUsd)
        .HasColumnType("int")
        .IsRequired();

        builder.HasOne(p => p.Prendas)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdPrenda);



        /* builder.HasIndex().IsUnique(); */
    }
}
