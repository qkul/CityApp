using CitiesApp.Infrastructure;
using CitiesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Repositories
{
    public class CitiesRepository : ICityRepository
    {
        private readonly CitiesAppContext _context;
      

        public IQueryable<City> Cities { get => _context.City; }
          public CitiesRepository(CitiesAppContext context)
        {
            _context = context;
        }

        public City GetCity(int id)
        {
            throw new NotImplementedException();
        }

        public City AddCity(City city)
        {
            throw new NotImplementedException();
        }

        public City EditCity(int cityId, City newCity)
        {
            throw new NotImplementedException();
        }

        public City DeleteCity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
