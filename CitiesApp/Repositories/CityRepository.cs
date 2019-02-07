using CitiesApp.Infrastructure;
using CitiesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CitiesApp.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(CitiesAppContext context) : base(context) { }

        public async Task UpdateCity(City city)
        {
            Update(city);
            await SaveAsync();
        }
    }
}
