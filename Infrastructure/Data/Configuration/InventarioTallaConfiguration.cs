using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
{
    public void Configure(EntityTypeBuilder<InventarioTalla> builder)
    {
        builder.ToTable("inventarioTalla");
        builder.HasKey(e => e.IdInv);
        builder.Property(e => e.IdInv);
        builder.HasKey(e => e.IdTalla);
        builder.Property(e => e.IdTalla);

        builder.Property(p => p.Cantidad)
        .HasColumnType("int")
        .IsRequired();
        
        builder.HasOne(p => p.Inventarios)
        .WithMany(p => p.InventarioTallas)
        .HasForeignKey(p => p.IdInv);

        builder.HasOne(p => p.Tallas)
        .WithMany(p => p.InventarioTallas)
        .HasForeignKey(p => p.IdTalla);
    }
}
