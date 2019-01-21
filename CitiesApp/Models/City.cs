using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CitiesApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        [Display(Name = "Year of creation")]
        public int YearOfCreation { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }

        public IQueryable<Photo> Photos { get; set; }
    }
}
