using CitiesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<City> Cities { get; set; }
        public PageViewModel PageViewModel { get; set; }// ???
        public FilterViewModel FilterViewModel { get; set;}
        public SortViewModel SortViewModel { get; set; }
    }
}
