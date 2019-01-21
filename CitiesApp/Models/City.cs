using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
