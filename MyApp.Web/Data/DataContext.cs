using Microsoft.EntityFrameworkCore;
using MyApp.Web.Data.Entities;

namespace MyApp.Web.Data
{
    public class DataContext : DbContext
    {
        //crea la conexion a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Lessee> Lessees { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }

    }
}
