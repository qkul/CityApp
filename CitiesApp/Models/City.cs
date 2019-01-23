using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CitiesApp.Models
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "City"), StringLength(30, MinimumLength = 3), Required(ErrorMessage = "please write the city name")]
        public string Name { get; set; }

        [StringLength(30, MinimumLength = 3), Required(ErrorMessage = "please write the country")]
        public string Country { get; set; }

        [Display(Name="Year of creation"), Range(0, 2019)]
        public int YearOfCreation { get; set; }

        public string Description { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
