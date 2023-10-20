using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("detalleVenta");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Cantidad).HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.ValorUnit).HasColumnType("int")
        .IsRequired();

        builder.HasOne(p => p.Ventas)
        .WithMany(p => p.DetallesVentas)
        .HasForeignKey(p => p.IdVenta);

        builder.HasOne(p => p.Tallas)
        .WithMany(p => p.DetallesVentas)
        .HasForeignKey(p => p.IdTalla);
        
        builder.HasOne(p => p.Inventarios)
        .WithMany(p => p.DetallesVentas)
        .HasForeignKey(p => p.IdProducto);
    }
}
