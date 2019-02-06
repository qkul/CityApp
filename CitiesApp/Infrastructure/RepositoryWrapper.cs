using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Infrastructure
{
    public interface IRepositoryWrapper
    {
        ICityRepository City { get; }
        IPhotoRepository Photo { get; }
    }
}
