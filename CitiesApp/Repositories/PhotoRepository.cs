using CitiesApp.Infrastructure;
using CitiesApp.Models;

namespace CitiesApp.Repositories
{
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(CitiesAppContext context) : base(context)
        {
        }
    }
}
