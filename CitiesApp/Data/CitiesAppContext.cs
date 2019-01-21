using Microsoft.EntityFrameworkCore;

namespace CitiesApp.Models
{
    public class CitiesAppContext : DbContext
    {
        public CitiesAppContext (DbContextOptions<CitiesAppContext> options)
            : base(options)
        {
        }

        public DbSet<City> City { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
