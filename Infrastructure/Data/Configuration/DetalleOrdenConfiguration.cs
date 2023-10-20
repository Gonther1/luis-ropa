using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("DetalleOrden");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.CantidadProducir)
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.CantidadProducida)
        .HasColumnType("int")
        .IsRequired();

        builder.HasOne(p => p.Colores)
        .WithMany(p => p.DetallesOrdenes)
        .HasForeignKey(p => p.IdColor);

        builder.HasOne(p => p.Ordenes)
        .WithMany(p => p.DetallesOrdenes)
        .HasForeignKey(p => p.IdOrden);

        builder.HasOne(p => p.Prendas)
        .WithMany(p => p.DetallesOrdenes)
        .HasForeignKey(p => p.IdPrenda);

        builder.HasOne(p => p.Estados)
        .WithMany(p => p.DetallesOrdenes)
        .HasForeignKey(p => p.IdEstado);
    }
}
