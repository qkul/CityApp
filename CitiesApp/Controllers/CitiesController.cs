using CitiesApp.Infrastructure;
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
        private readonly IRepositoryWrapper _repoWrapper;

        public CitiesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        //private readonly ICityRepository _repoWrapper;
        //private readonly IPhotoRepository _repoWrapper;
        //public CitiesController(ICityRepository cityRepository, IPhotoRepository photoRepository)
        //{
        //    _repoWrapper = cityRepository;//_cityRepository
        //    _repoWrapper = photoRepository;//_photoRepositoty
        //}
        //private readonly CitiesAppContext _context;
        //public CitiesController(CitiesAppContext context)
        //{
        //    _context = context;
        //}

        // GET: Cities
        public async Task<IActionResult> Index(
            string sortOrder,
            string searchName, string searchCountry,
            string currentFilter,
            int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSort"] = string.IsNullOrEmpty(sortOrder) ? Defines.CitiesConroll.CITY_DESC : string.Empty;//sorting cities by name
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
            
            var cities = _repoWrapper.City.CitiesSAll();
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
                await _repoWrapper.City.CreateCityAsync(city);
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

            var city = await _repoWrapper.City.GetCitiesByIdAsync(id);
            //var city = await _cityRepository.GetCitiesByIdAsync(id);
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
                    await _repoWrapper.City.UpdateOwnerAsync(city);
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
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = _repoWrapper.City.GetCitiesDefault(id);
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
            var city = await _repoWrapper.City.GetCitiesByIdAsync(id);
            await _repoWrapper.City.DeleteCityAsync(city);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult More(int id)
        {
            var city = _repoWrapper.City.GetCitiesDefault(id);
            if (city == null)
            {
                return RedirectToAction("Index", "Cities");
            }

            var photos = _repoWrapper.Photo.GetPhotoWhere(id);
            return View(new CityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                Description = city.Description,
                Photos = photos
            });
        }

        // GET: /Cities/GetPhoto
        public IActionResult GetPhoto(int? id)
        {
            var photo = _repoWrapper.Photo.GetPhotosDefault(id);
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
            //_photoRepositoty.CreatePhotoAsync(photo);
            _repoWrapper.Photo.CreatePhoto(photo);
            return RedirectToAction("More", new { id = model.CityId });
        }

        // GET: /Cities/DeletePhoto
        public IActionResult DeletePhoto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            var photo = _repoWrapper.Photo.GetPhotosDefault(id);
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
            var photo = await _repoWrapper.Photo.GetPhotoFindIdAsync(id);
            await _repoWrapper.Photo.DeletePhotoAsync(photo);
            return RedirectToAction("More", "Cities", new { id = photo.CityId });
        }

        // GET: Cities/AllCities
        public ActionResult AllCities()
        {
            var city = _repoWrapper.City.CitiesOrderBy();
            return PartialView(city);
        }

        // GET: Cities/AllCitiesJson
        public ActionResult AllCitiesJson()
        {
            var city = _repoWrapper.City.CitiesOrderBy();
            return Json(city);
        }

        private bool CityExists(int id)
        {
            return _repoWrapper.City.CityExits(id);
        }
    }
}