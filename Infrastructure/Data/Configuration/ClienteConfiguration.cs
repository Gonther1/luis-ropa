using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.IdCliente).HasColumnType("int")
        .IsRequired();

        builder.HasIndex(p => p.IdCliente).IsUnique(); // Si estoy

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaRegistro).HasColumnType("datetime")
        .IsRequired();
        
        builder.HasOne(p => p.Municipios)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.IdMunicipio);

        builder.HasOne(p => p.TiposPersonas)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.IdTipoPersona);
        
    }
}
