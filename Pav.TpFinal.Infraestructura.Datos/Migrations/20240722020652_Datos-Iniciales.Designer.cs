﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pav.TpFinal.Infraestructura.Datos;

#nullable disable

namespace Pav.TpFinal.Infraestructura.Datos.Migrations
{
    [DbContext(typeof(PavTpFinalContext))]
    [Migration("20240722020652_Datos-Iniciales")]
    partial class DatosIniciales
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Empleado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Documento")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Domicilio")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Empleados", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"),
                            Documento = "12345678",
                            Domicilio = "Tucumán",
                            Nombre = "Luis"
                        },
                        new
                        {
                            Id = new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"),
                            Documento = "87654321",
                            Domicilio = "Tucumán",
                            Nombre = "María"
                        });
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Especie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("PorcentajePesoCarne")
                        .HasColumnType("float");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Especies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5939c016-d55a-4b8c-9aba-5838e63e1dcd"),
                            Codigo = 1,
                            Nombre = "León",
                            PorcentajePesoCarne = 0.69999999999999996,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("ef3d940f-7074-4e8e-8c92-1dd3646f1c8d"),
                            Codigo = 2,
                            Nombre = "Jirafa",
                            PorcentajePesoCarne = 0.0,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("e39f3776-83e1-4bd8-a008-a5a7b882b669"),
                            Codigo = 3,
                            Nombre = "Tigre",
                            PorcentajePesoCarne = 0.5,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("23afb064-70fb-4e2f-bc73-9da9328d0efc"),
                            Codigo = 4,
                            Nombre = "Rinoceronte",
                            PorcentajePesoCarne = 0.0,
                            TipoAlimentacion = 1
                        });
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Mamifero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<Guid?>("EspecieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("PaisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Peso")
                        .HasPrecision(6, 2)
                        .HasColumnType("float(6)");

                    b.Property<Guid?>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.HasIndex("PaisId");

                    b.HasIndex("SectorId");

                    b.ToTable("Mamiferos", (string)null);

                    b.HasDiscriminator<int>("TipoAlimentacion");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Paises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3eaa8ec-249c-42a6-b973-eeaed730d249"),
                            Nombre = "Sudáfrica"
                        },
                        new
                        {
                            Id = new Guid("cd28016f-5f96-43f7-930e-ce7fd02a946d"),
                            Nombre = "Australia"
                        },
                        new
                        {
                            Id = new Guid("fa4dd464-68e9-49c4-8a9b-5e366ecf219b"),
                            Nombre = "Singapur"
                        },
                        new
                        {
                            Id = new Guid("b82d4bc8-947f-40c6-ba6f-5b569093cfa4"),
                            Nombre = "Canadá"
                        });
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitud")
                        .HasPrecision(10, 8)
                        .HasColumnType("float(10)");

                    b.Property<int>("Limite")
                        .HasColumnType("int");

                    b.Property<double>("Longitud")
                        .HasPrecision(10, 8)
                        .HasColumnType("float(10)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("TipoAlimentacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Sectores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("02587be7-f14f-4156-acf3-719bdda2b65b"),
                            EmpleadoId = new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"),
                            Latitud = -26.250724000000002,
                            Limite = 10,
                            Longitud = -65.522827000000007,
                            Numero = 1,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("4bb489c4-6051-492e-87c6-7fe43ba5203e"),
                            EmpleadoId = new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"),
                            Latitud = -26.252358999999998,
                            Limite = 10,
                            Longitud = -65.521511000000004,
                            Numero = 2,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("b70d9a62-447c-402b-bd52-77560c909aad"),
                            EmpleadoId = new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"),
                            Latitud = -26.254660999999999,
                            Limite = 10,
                            Longitud = -65.522726000000006,
                            Numero = 3,
                            TipoAlimentacion = 1
                        },
                        new
                        {
                            Id = new Guid("372169cb-3b25-4172-bf32-5eed62bd13ae"),
                            EmpleadoId = new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"),
                            Latitud = -26.257249999999999,
                            Limite = 10,
                            Longitud = -65.523514000000006,
                            Numero = 4,
                            TipoAlimentacion = 0
                        },
                        new
                        {
                            Id = new Guid("97bccd96-11c1-4776-a8a8-dbc29088df25"),
                            EmpleadoId = new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"),
                            Latitud = -26.257249999999999,
                            Limite = 10,
                            Longitud = -65.523514000000006,
                            Numero = 5,
                            TipoAlimentacion = 0
                        });
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Carnivoro", b =>
                {
                    b.HasBaseType("Pav.TpFinal.Dominio.Entidades.Mamifero");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Herbivoro", b =>
                {
                    b.HasBaseType("Pav.TpFinal.Dominio.Entidades.Mamifero");

                    b.Property<double>("ValorFijo")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Mamifero", b =>
                {
                    b.HasOne("Pav.TpFinal.Dominio.Entidades.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId");

                    b.HasOne("Pav.TpFinal.Dominio.Entidades.Pais", "Origen")
                        .WithMany()
                        .HasForeignKey("PaisId");

                    b.HasOne("Pav.TpFinal.Dominio.Entidades.Sector", "Sector")
                        .WithMany("Animales")
                        .HasForeignKey("SectorId");

                    b.Navigation("Especie");

                    b.Navigation("Origen");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Sector", b =>
                {
                    b.HasOne("Pav.TpFinal.Dominio.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Pav.TpFinal.Dominio.Entidades.Sector", b =>
                {
                    b.Navigation("Animales");
                });
#pragma warning restore 612, 618
        }
    }
}