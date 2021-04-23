using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudNetCore5.Migrations
{
    public partial class Table1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Asignar",
                columns: table => new
                {
                    AsignarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVenc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    DescAsignacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rut = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Asignar", x => x.AsignarId);
                });

            migrationBuilder.CreateTable(
                name: "_ContratoServicios",
                columns: table => new
                {
                    NumContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutContratista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaTermino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ContratoServicios", x => x.NumContrato);
                });

            migrationBuilder.CreateTable(
                name: "_Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NombreProd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescripcionProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    NroSerie = table.Column<int>(type: "int", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoInventario = table.Column<int>(type: "int", nullable: false),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscoDuro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SistemaOper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    AsignarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "_Persona",
                columns: table => new
                {
                    Rut = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Materno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Persona", x => x.Rut);
                });

            migrationBuilder.CreateTable(
                name: "_Sector",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodCaja = table.Column<int>(type: "int", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sector", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "_Sucursal",
                columns: table => new
                {
                    CodCaja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCaja = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sucursal", x => x.CodCaja);
                });

            migrationBuilder.CreateTable(
                name: "_Ubicacion",
                columns: table => new
                {
                    UbicacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVenc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ubicacion", x => x.UbicacionId);
                });

            migrationBuilder.CreateTable(
                name: "_Usuarios",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vigente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios", x => x.Numero);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Asignar");

            migrationBuilder.DropTable(
                name: "_ContratoServicios");

            migrationBuilder.DropTable(
                name: "_Item");

            migrationBuilder.DropTable(
                name: "_Persona");

            migrationBuilder.DropTable(
                name: "_Sector");

            migrationBuilder.DropTable(
                name: "_Sucursal");

            migrationBuilder.DropTable(
                name: "_Ubicacion");

            migrationBuilder.DropTable(
                name: "_Usuarios");
        }
    }
}
