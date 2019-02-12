using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CitiesApp.ViewModels
{
    public class PhotoViewModel
    {
        [ScaffoldColumn(false)]// completely hide the property from the helpers
        public int CityId { get; set; }
        [Required(ErrorMessage = "please write the place name")]
        public string PhotoInfo { get; set; }
        public IFormFile Image { get; set; }
    }
}
