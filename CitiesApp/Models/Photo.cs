using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Models
{
    public class Photo
    {
        public int Id { get; set; }     
        public string PhotoInfo { get; set; }
        public byte[] Image { get; set; }
        public string ImageType { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
    }
}
