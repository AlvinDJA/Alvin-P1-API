using Alvin_P1_API.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alvin_P1_API.DAL
{
    public class Contexto : DbContext
    {
       public DbSet<Ciudades> Ciudades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=DATA\DBParcial1.db");
        }
    }
}
