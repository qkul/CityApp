using Microsoft.AspNetCore.Http;

namespace CitiesApp.ViewModels
{
    public class PhotoViewModel
    {
        public int CityId { get; set; }
        public IFormFile Image { get; set; }
    }
}
