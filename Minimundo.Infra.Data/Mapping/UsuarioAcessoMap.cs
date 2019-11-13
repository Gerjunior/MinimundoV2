﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minimundo.Domain.Entities;

namespace Minimundo.Infra.Data.Mapping
{
    public class UsuarioAcessoMap : IEntityTypeConfiguration<UsuarioAcesso>
    {
        public void Configure(EntityTypeBuilder<UsuarioAcesso> builder)
        {
            builder.ToTable("UsuarioAcesso");

            builder.HasKey(k => k.UserID);

            builder.Property(p => p.UserID)
                   .HasColumnName("UserID")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(p => p.AccessKey)
                .IsRequired()
                .HasColumnName("AccessKey")
                .HasMaxLength(255);

            builder.Property(p => p.CriadoPor)
                   .HasColumnName(@"CriadoPor")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.CriadoEm)
                   .HasColumnName(@"CriadoEm")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.ModificadoPor)
                   .HasColumnName(@"ModificadoPor")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.ModificadoEm)
                   .HasColumnName(@"ModificadoEm")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.Ativo)
                   .HasColumnName(@"Ativo")
                   .HasColumnType("bit")
                   .IsRequired();
        }
    }
}