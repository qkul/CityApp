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
        Task UpdateCity(City city);
    }
}
