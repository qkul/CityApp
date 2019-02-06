using CitiesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Infrastructure
{
    public interface IPhotoRepository : IRepositoryBase<Photo>
    {
        ICollection<Photo> GetPhotoWhere(int? id);
        Photo GetPhotosDefault(int? id);
        //Task CreatePhoto(Photo photo);
        Task DeletePhotoAsync(Photo photo);
        Task<Photo> GetPhotoFindIdAsync(int? id);
        void CreatePhoto(Photo photo);
    }
}
