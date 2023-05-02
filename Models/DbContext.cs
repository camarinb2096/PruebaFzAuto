using Microsoft.EntityFrameworkCore;
using AppAcceso.Models;

namespace ControlAcceso.Models
{
    //Creando el contexto para la base de datos y generar el modelo de acuerdo a las tablas de la BD    
    public class ControlAccesoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ZonaAcceso> Zonas { get; set; }
        public DbSet<NivelAcceso> NivelesAcceso { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<TipoRegistro> TiposRegistros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IVVRU2M5\MSSQLSERVER01;Initial Catalog=ControlAcceso;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuraciones adicionales
        }
    }
}
