﻿// <auto-generated />
using System;
using CrudNetCore5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudNetCore5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210421193443_TableTipo")]
    partial class TableTipo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudNetCore5.Models.Asignar", b =>
                {
                    b.Property<int>("AsignarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("DescAsignacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVenc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rut")
                        .HasColumnType("int");

                    b.HasKey("AsignarId");

                    b.ToTable("_Asignar");
                });

            modelBuilder.Entity("CrudNetCore5.Models.ContratoServicios", b =>
                {
                    b.Property<int>("NumContrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTermino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutContratista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumContrato");

                    b.ToTable("_ContratoServicios");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Familia", b =>
                {
                    b.Property<int>("FamiliaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescFamilia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FamiliaId");

                    b.ToTable("_Familia");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignarId")
                        .HasColumnType("int");

                    b.Property<int>("CodigoInventario")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscoDuro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NombreProd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("NroSerie")
                        .HasColumnType("int");

                    b.Property<string>("Procesador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SistemaOper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("_Item");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Personas", b =>
                {
                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paterno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rut");

                    b.ToTable("_Persona");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Sector", b =>
                {
                    b.Property<int>("SectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodCaja")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("SectorId");

                    b.ToTable("_Sector");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Sucursal", b =>
                {
                    b.Property<int>("CodCaja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCaja")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CodCaja");

                    b.ToTable("_Sucursal");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Tipo", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FamiliaId")
                        .HasColumnType("int");

                    b.HasKey("TipoId");

                    b.ToTable("_Tipo");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Ubicacion", b =>
                {
                    b.Property<int>("UbicacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVenc")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("UbicacionId");

                    b.ToTable("_Ubicacion");
                });

            modelBuilder.Entity("CrudNetCore5.Models.Usuarios", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vigente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numero");

                    b.ToTable("_Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
