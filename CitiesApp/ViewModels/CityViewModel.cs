using CitiesApp.Models;
using System.Collections.Generic;

namespace CitiesApp.ViewModels
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
