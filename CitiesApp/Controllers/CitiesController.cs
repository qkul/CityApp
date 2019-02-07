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

        //fix 1 interface
        //fix 2 Controller(city/photo)

        //private readonly ICityRepository _cityRepository;
        //private readonly IPhotoRepository _photoRepositoty;
        //public CitiesController(ICityRepository cityRepository, IPhotoRepository photoRepository)
        //{
        //    _cityRepository = cityRepository;//_cityRepository
        //    _photoRepositoty = photoRepository;//_photoRepositoty
        //}

        private readonly CitiesAppContext _context;
        public CitiesController(CitiesAppContext context)
        {
            _context = context;
        }

        //GET: Cities
        public async Task<IActionResult> Index(string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            var cities = _context.City.Select(x => x);
            
            //Filter
            if (!string.IsNullOrEmpty(name))
            {
                cities = cities.Where(c => c.Name.Contains(name));
            }

            //sort
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    cities = cities.OrderByDescending(c => c.Name);
                    break;
                case SortState.RatingAsc:
                    cities = cities.OrderBy(c => c.Rating);
                    break;
                case SortState.RatingDesc:
                    cities = cities.OrderByDescending(c => c.Rating);
                    break;
                default:
                    cities = cities.OrderBy(c => c.Name);
                    break;
            }

            //pagination
            int pageSize = 7;
            var count = await cities.CountAsync();
            var items = await cities.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(_context.City.ToList(), name),
                Cities = items
            };
            return View(viewModel);
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
                // await _cityRepository.CreateCityAsync(city);
                _context.Add(city);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            //var city = await _cityRepository.GetCitiesByIdAsync(id);
            var city = await _context.City.FindAsync(id);
            if (city == null) return NotFound();

            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Country,YearOfCreation,Description,Rating")] City city)
        {
            if (id != city.Id) return NotFound();
            if (!ModelState.IsValid) return View(city);

            try
            {
                //await _cityRepository.UpdateOwnerAsync(city);
                _context.Update(city);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(city.Id))
                    return NotFound();
                else
                    throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Cities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            //var city = _cityRepository.GetCitiesDefault(id);
            var city = await _context.City
               .FirstOrDefaultAsync(m => m.Id == id);
            if (city == null) return NotFound();

            return View(city);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var city = await _cityRepository.GetCitiesByIdAsync(id);
            //await _cityRepository.DeleteCityAsync(city);
            var city = await _context.City.FindAsync(id);
            _context.City.Remove(city);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> More(int id)
        {
            // var city = _cityRepository.GetCitiesDefault(id);
            var city = await _context.City.FirstOrDefaultAsync(c => c.Id == id);
            if (city == null)
            {
                return RedirectToAction("Index", "Cities");
            }

            // var photos = _photoRepositoty.GetPhotoWhere(id);
            var photos = await _context.Photos.Where(p => p.CityId == id).ToListAsync();
            return View(new CityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                Description = city.Description,
                Photos = photos
            });
        }

        

        // GET: Cities/AllCities
        public ActionResult AllCities()
        {
            // var city = _cityRepository.CitiesOrderBy();
            var city = _context.City.OrderBy(c => c.Name);
            return PartialView(city);
        }

        // GET: Cities/AllCitiesJson
        public ActionResult AllCitiesJson()
        {
            //var city = _cityRepository.CitiesOrderBy();
            var city = _context.City.OrderBy(c => c.Name);
            return Json(city);
        }

        private bool CityExists(int id)
        {
            //  return _cityRepository.CityExits(id);
            return _context.City.Any(e => e.Id == id);
        }
    }
}