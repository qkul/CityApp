using CitiesApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(List<City> cities,  string name)
        {
            cities.Insert(0, new City { Name = "All", Id = 0 });
            SelectedName = name;
        }
        public SelectList Cities { get; private set; } // list cities
        public string SelectedName { get;  }
    }
}
