using CitiesApp.Models;
using CitiesApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.Controllers
{
    public class CitiesController : Controller
    {
        private readonly CitiesAppContext _context;

        public CitiesController(CitiesAppContext context)
        {
            _context = context;
        }

        // GET: Cities
        public async Task<IActionResult> Index(string searchCountry, string searchName, string sortOrder)
        {
            ViewBag.NameSort = string.IsNullOrEmpty(sortOrder) ? "city_desc" : "";//sorting cities by name
            ViewBag.RatingSort = sortOrder == "rating" ? "rating_desc" : "rating";// sorting cities by rating

            ViewBag.StrSearchName = searchName;
            ViewBag.StrSearchCountry = searchCountry;

            var cities = _context.City.Select(x => x);
            if (!string.IsNullOrEmpty(searchName))//check or name contains (search by city name)
            {
                cities = cities.Where(s => s.Name.Contains(searchName));
            }
            if (!string.IsNullOrEmpty(searchCountry))//search by country name
            {
                cities = cities.Where(s => s.Country.Contains(searchCountry));
            }
            switch (sortOrder)
            {
                case "city_desc":
                    cities = cities.OrderByDescending(c => c.Name);
                    break;
                case "rating":
                    cities = cities.OrderBy(c => c.Rating);
                    break;
                case "rating_desc":
                    cities = cities.OrderByDescending(c => c.Rating);
                    break;
                default:
                    cities = cities.OrderBy(c => c.Name);
                    break;
            }
            return View(await cities.ToListAsync());
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City
                .FirstOrDefaultAsync(m => m.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Cities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Country,YearOfCreation,Description,Rating")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Add(city);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Country,YearOfCreation,Description,Rating")] City city)
        {
            if (id != city.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(city);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City
                .FirstOrDefaultAsync(m => m.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var city = await _context.City.FindAsync(id);
            _context.City.Remove(city);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> More(int id)
        {
            var city = await _context.City.FirstOrDefaultAsync(c => c.Id == id);
            if (city == null)
            {
                return RedirectToAction("Index", "Cities");
            }

            var photos = await _context.Photos.Where(p => p.CityId == id).ToListAsync();
            return View(new CityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                Photos = photos
            });
        }

        public async Task<IActionResult> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);

            if (photo == null)
            {
                return NotFound();
            }

            return File(photo.Image, photo.ImageType);
        }

        public IActionResult AddPhoto(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cities");
            }
            return View(new PhotoViewModel { CityId = id.Value });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPhoto(PhotoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var photo = new Photo { CityId = model.CityId, ImageType = model.Image.ContentType };
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
            _context.Photos.Add(photo);
            _context.SaveChanges();
            return RedirectToAction("More", new { id = model.CityId });
        }

        //[HttpPost]
        //public async Task<IActionResult> AddPhoto(Photo photos, List<IFormFile> Image)
        //{
        //    var photo = new Photo
        //    {           
        //        CityId = photos.CityId
        //    };
        //    if (!ModelState.IsValid)
        //    {
        //        return View(photos);
        //    }
        //        foreach (var item in Image)
        //    {
        //        if (item.Length > 0)
        //        {
        //            using (var stream = new MemoryStream())
        //            {
        //                await item.CopyToAsync(stream);
        //                photo.Image = stream.ToArray();
        //            }
        //        }
        //    }
        //    _context.Photos.Add(photo);
        //    _context.SaveChanges();// id
        //    return RedirectToAction("More", new
        //    {
        //        id = photos.CityId
        //    });
        //}
        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.Id == id);
        }
    }
}
