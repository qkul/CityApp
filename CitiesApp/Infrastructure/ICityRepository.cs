using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesApp.Models;

namespace CitiesApp.Infrastructure
{
    public interface ICityRepository
    {
        IQueryable<City> Cities { get; }
        City GetCity(int id);
        City AddCity(City city);
        City EditCity(int cityId, City newCity);
        City DeleteCity(int id);
    }
}
