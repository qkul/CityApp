using CitiesApp.Infrastructure;
using CitiesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly CitiesAppContext _context;
        private ICityRepository _city;
        private IPhotoRepository _photo;

        public ICityRepository City
        {
            get
            {
                if (_city == null)
                {
                    _city = new CityRepository(_context);
                }

                return _city;
            }
        }

        public IPhotoRepository Photo
        {
            get
            {
                if (_photo == null)
                {
                    _photo = new PhotoRepository(_context);
                }

                return _photo;
            }
        }

        public RepositoryWrapper(CitiesAppContext context)
        {
            _context = context;
        }
    }
}
