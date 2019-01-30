using CitiesApp.Models;
using CitiesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index(
            string sortOrder,
            string searchName, string searchCountry, 
            string currentFilter,
            int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSort"] = string.IsNullOrEmpty(sortOrder) ? Defines.CitiesConroll.CITY_DESC  : string.Empty;//sorting cities by name
            ViewData["RatingSort"] = sortOrder == Defines.CitiesConroll.RATING ? Defines.CitiesConroll.RATING_DESK : Defines.CitiesConroll.RATING;// sorting cities by rating
            ViewData["StrSearchName"] = searchName;

            if (searchName != null)
            {
                page = 1;
            }
            else
            {
                searchName = currentFilter;
            }
            ViewData["CurrentFilter"] = searchName;

            var cities = _context.City.Select(x => x);
            if (!string.IsNullOrEmpty(searchName))//check or name contains (search by city name)
            {
                cities = cities.Where(s => s.Name.Contains(searchName));
            }

            switch (sortOrder)
            {
                case Defines.CitiesConroll.CITY_DESC:
                    cities = cities.OrderByDescending(c => c.Name);
                    break;
                case Defines.CitiesConroll.RATING:
                    cities = cities.OrderBy(c => c.Rating);
                    break;
                case Defines.CitiesConroll.RATING_DESK:
                    cities = cities.OrderByDescending(c => c.Rating);
                    break;
                default:
                    cities = cities.OrderBy(c => c.Name);
                    break;
            }
            int pageSize = 7;
            return View(await PaginatedList<City>.CreateAsync(cities.AsNoTracking(), page ?? 1, pageSize));
            // return View(await cities.ToListAsync());
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
                Description = city.Description,
                Photos = photos
            });
        }

        // GET: /Cities/GetPhoto
        public async Task<IActionResult> GetPhoto(int? id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);

            if (photo == null)
            {
                return NotFound();
            }

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
            _context.Photos.Add(photo);
            _context.SaveChanges();
            return RedirectToAction("More", new { id = model.CityId });
        }

        // GET: /Cities/DeletePhoto
        public async Task<IActionResult> DeletePhoto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // POST: Cities/DeletePhoto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();
            return RedirectToAction("More","Cities", new { id = photo.CityId});
        }

        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.Id == id);
        }
    }
}
