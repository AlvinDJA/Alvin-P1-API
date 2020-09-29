using Microsoft.EntityFrameworkCore;

namespace Alvin_P1_API.DAL
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
