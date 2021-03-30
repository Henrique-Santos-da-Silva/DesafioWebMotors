﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteBackendWebMotors.Data.DataContext;

namespace TesteBackendWebMotors.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210329153927_Implement_Database_Mapper_Migration")]
    partial class Implement_Database_Mapper_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteBackendWebMotors.Data.Entities.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("ano");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("marca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("modelo");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<int>("Quilometragem")
                        .HasColumnType("int")
                        .HasColumnName("quilometragem");

                    b.Property<string>("Versao")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("versao");

                    b.HasKey("Id");

                    b.ToTable("tb_AnuncioWebmotors");
                });
#pragma warning restore 612, 618
        }
    }
}
