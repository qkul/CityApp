using System.Threading.Tasks;
using CitiesApp.Infrastructure;
using CitiesApp.Models;

namespace CitiesApp.Repositories
{
    public class PhotoRepository : RepositoryBase<Photo>
    {
        public PhotoRepository(CitiesAppContext context) : base(context){}
    }
}
