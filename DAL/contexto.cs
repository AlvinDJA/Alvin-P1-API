using Microsoft.EntityFrameworkCore;
using Alvin-P1-AP1.Entidades;

namespace Alvin-P1-AP1.DAL
{
    public class Contexto : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=DATA\DBParcial1.db");
        }
    }
}
