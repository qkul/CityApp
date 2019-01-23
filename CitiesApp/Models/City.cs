using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CitiesApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int YearOfCreation { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
