using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesApp.Infrastructure;
using CitiesApp.Migrations;
using CitiesApp.Models;
using Microsoft.EntityFrameworkCore;
using Photo = CitiesApp.Models.Photo;

namespace CitiesApp.Repositories
{
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(CitiesAppContext context) : base(context)
        {
        }

        public ICollection<Photo> GetPhotoWhere(int? id)
        {
            return _context.Photos.Where(p => p.CityId == id).ToList();
        }
        public Photo GetPhotosDefault(int? id)
        {
            return _context.Photos.FirstOrDefault(c => c.Id == id);
        }
        /*public async Task CreatePhotoAsync(Photo photo)
        //{
        //    _context.Add(photo);
        //    await _context.SaveChangesAsync();
        }*///not working, not determined photo id

        public void CreatePhoto(Photo photo)
        {
            _context.Add(photo);
            _context.SaveChanges();
        }

        public async Task DeletePhotoAsync(Photo photo)
        {
            Delete(photo);
            await SaveAsync();
        }
        public async Task<Photo> GetPhotoFindIdAsync(int? id)
        {
            return await _context.Photos.FindAsync(id);
        }

    }
}
