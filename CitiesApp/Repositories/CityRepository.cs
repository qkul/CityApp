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

        public IQueryable<City> CitiesSAll()
        {
            return _context.City.Select(x => x);
        }

        public IQueryable<City> CitiesOrderBy()
        {
            return _context.City.OrderBy(x => x.Name);
        }

        public async Task CreateCityAsync(City city)
        {
            _context.Add(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCityAsync(City city)
        {
            Delete(city);
            await SaveAsync();
        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            var cities = await FindAllAsync();
            return cities.OrderBy(x => x.Name);
        }

        public async Task<City> GetCitiesByIdAsync(int? id)
        {
            //var city = await FindByConditionAync(c => c.Id.Equals(cityId));
            //return city.DefaultIfEmpty(new City()).FirstOrDefault();
            //return await _context.FindAsync(cityId);
            return await _context.City.FindAsync(id);
        }

        public City GetCitiesDefault(int? id)
        {
            return _context.City.FirstOrDefault(c => c.Id == id);
        }

        public async Task UpdateOwnerAsync(City city)
        {
            Update(city);
            await SaveAsync();
        }


        bool ICityRepository.CityExits(int id)
        {
            return _context.City.Any(e => e.Id == id);
        }
    }
}
