using CitiesApp.Infrastructure;
using CitiesApp.Models;
using CitiesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace CitiesApp.Controllers
{
    public class PhotosController : Controller
    {
        private readonly IPhotoRepository _photoRepositoty;
        public PhotosController(IPhotoRepository photoRepository)
        {
            _photoRepositoty = photoRepository;//_photoRepositoty
        }

        // GET: /Cities/GetPhoto
        public async Task <IActionResult> GetPhoto(int? id)
        {
            var photo = await _photoRepositoty.FirtsOrDefaoultAsync(p => p.Id == id);
            if (photo == null) return NotFound();

            return File(photo.Image, photo.ImageType);
        }

        // GET: /Cities/AddPhoto
        public IActionResult AddPhoto(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cities");
            }
            return View(new PhotoViewModel { CityId = id.Value });
        }

        // POST: /Cities/AddPhoto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPhoto(PhotoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            if (model.Image == null)
            {
                return View();
            }
            var photo = new Photo { CityId = model.CityId, ImageType = model.Image.ContentType, PhotoInfo = model.PhotoInfo };
            if (model.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(model.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)model.Image.Length);
                }
                // установка массива байтов
                photo.Image = imageData;
            }
            _photoRepositoty.Add(photo);
            return RedirectToAction("More","Cities", new { id = model.CityId });
        }

        // GET: /Cities/DeletePhoto
        public async Task <IActionResult> DeletePhoto(int? id)
        {
            if (id == null) return NotFound();
            var photo = await _photoRepositoty.FirtsOrDefaoultAsync(p => p.Id == id);
            if (photo == null) return NotFound();

            return View(photo);
        }

        // POST: Cities/DeletePhoto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            //var photo = await _photoRepositoty.GetPhotoFindIdAsync(id);
            //await _photoRepositoty.DeletePhotoAsync(photo);

            /* 
            var photo1 = _context.Photos.Remove( new Photo { Id = id} );
            await _context.SaveChangesAsync();
            return RedirectToAction("More", "Cities");
            */// The transation to the main page does not work

            var photo = await _photoRepositoty.GetAsync(id);
            await _photoRepositoty.DeleteAsyn(photo);
            return RedirectToAction("More", "Cities", new { id = photo.CityId });
        }
    }
}