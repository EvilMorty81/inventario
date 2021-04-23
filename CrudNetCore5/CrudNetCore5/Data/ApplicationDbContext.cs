using CrudNetCore5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        { 

        }
        public DbSet<Personas> _Persona { get; set; }
      
        public DbSet<Item> _Item { get; set; }
        public DbSet<ContratoServicios> _ContratoServicios { get; set; }
        public DbSet<Usuarios> _Usuarios { get; set; }
        public DbSet<Asignar>  _Asignar { get; set; }
        public DbSet<Sucursal> _Sucursal { get; set; }
        public DbSet<Sector> _Sector { get; set; }
        public DbSet<Ubicacion> _Ubicacion { get; set; }
        public DbSet<Familia> _Familia { get; set; }
        public DbSet<Tipo> _Tipo { get; set; }
    }
}
