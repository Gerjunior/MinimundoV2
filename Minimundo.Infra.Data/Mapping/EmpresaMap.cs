﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(k => k.EmpresaID);

            builder.Property(p => p.EmpresaID)
                   .HasColumnName(@"EmpresaID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.NomeFantasia)
                   .HasColumnName(@"NomeFantasia")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.CNPJ)
                   .HasColumnName(@"CNPJ")
                   .HasColumnType("char")
                   .HasMaxLength(14)
                   .IsRequired();

            builder.Property(p => p.RazaoSocial)
                   .HasColumnName(@"RazaoSocial")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}