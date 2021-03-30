using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteBackendWebMotors.Data.Entities;

namespace TesteBackendWebMotors.Data.Mapper
{
    public class AnuncioMapper : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.ToTable("tb_AnuncioWebmotors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID").IsRequired();
            builder.Property(x => x.Marca).HasColumnName("marca").HasColumnType("varchar(45)").IsRequired();
            builder.Property(x => x.Modelo).HasColumnName("modelo").HasColumnType("varchar(45)").IsRequired();
            builder.Property(x => x.Versao).HasColumnName("versao").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Ano).HasColumnName("ano").IsRequired();
            builder.Property(x => x.Quilometragem).HasColumnName("quilometragem").HasColumnType("int").IsRequired();
            builder.Property(x => x.Observacao).HasColumnName("observacao").HasColumnType("text").IsRequired();
        }
    }
}
