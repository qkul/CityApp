using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CitiesApp.Models
{
    public class CitiesAppContext : DbContext
    {
        public CitiesAppContext (DbContextOptions<CitiesAppContext> options)
            : base(options)
        {
        }

        public DbSet<CitiesApp.Models.City> City { get; set; }
    }
}
