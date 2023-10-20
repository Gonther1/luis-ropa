using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {
        builder.ToTable("Prenda");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);


        builder.Property(p => p.IdPrenda)
        .HasColumnType("int")
        .IsRequired();

        builder.HasIndex(p =>p.IdPrenda)
        .IsUnique();  // Si estoy

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
        
        builder.Property(p => p.ValorUnitCop)
        .HasColumnType("int")
        .IsRequired(); 

        builder.Property(p => p.ValorUnitUsd)
        .HasColumnType("int")
        .IsRequired(); 

        builder.HasOne(p => p.Estados)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdEstado);

        builder.HasOne(p => p.TiposProtecciones)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdTipoProteccion);

        builder.HasOne(p => p.Generos)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdGenero);
    }
}
