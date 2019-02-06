using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CitiesApp.Models;

namespace CitiesApp.Infrastructure
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        Task<IEnumerable<City>> GetAllCitiesAsync();
        Task<City> GetCitiesByIdAsync(int? id);
        Task CreateCityAsync(City city);
        Task DeleteCityAsync(City city);
        IQueryable<City> CitiesSAll();
        IQueryable<City> CitiesOrderBy();
        Task UpdateOwnerAsync(City city);
        City GetCitiesDefault(int? id);
        bool CityExits(int id);
    }
}
