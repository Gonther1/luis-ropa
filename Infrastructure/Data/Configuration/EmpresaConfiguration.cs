using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("Empresa");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nit)
        .HasColumnType("int")
        .IsRequired();

        builder.HasIndex(p => p.Nit)
        .IsUnique(); // Si estoy

        builder.Property(p => p.RazonSocial)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.RepresentacionLegal)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaCreacion)
        .HasColumnType("datetime")
        .IsRequired();
        
        builder.HasOne(p => p.Municipios)
        .WithMany(p => p.Empresas)
        .HasForeignKey(p => p.IdMun);
    }
}
