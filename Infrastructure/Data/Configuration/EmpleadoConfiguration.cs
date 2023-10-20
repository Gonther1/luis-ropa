using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleado");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);
        
        builder.Property(p => p.IdEmp).HasColumnType("int")
        .IsRequired();

        builder.HasIndex(p => p.IdEmp).IsUnique(); // Si estoy

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaIngreso)
        .HasColumnType("datetime")
        .IsRequired();

        builder.HasOne(p => p.Cargos)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.IdCargo);

        builder.HasOne(p => p.Municipios)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.IdMunicipio);
        
    }
}
