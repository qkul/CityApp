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

        private readonly ICityRepository _cityRepository;
        private readonly IPhotoRepository _photoRepositoty;
        public CitiesController(ICityRepository cityRepository, IPhotoRepository photoRepository)
        {
            _cityRepository = cityRepository;//_cityRepository
            _photoRepositoty = photoRepository;//_photoRepositoty
        }

        //GET: Cities
        public async Task<IActionResult> Index(string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            var cities = _cityRepository.GetAllSelect(x => x);
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
                FilterViewModel = new FilterViewModel(_cityRepository.GetAll(), name),
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
                await _cityRepository.AddAsyn(city);
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var city = await _cityRepository.GetAsync(id);
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
                await _cityRepository.UpdateCity(city);
            }
            catch (DbUpdateConcurrencyException)
            {         
                    throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Cities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var city = await _cityRepository.FirtsOrDefaoultAsync(m => m.Id == id);
            if (city == null) return NotFound();

            return View(city);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var city = await _cityRepository.DeleteAsyn(new City { Id = id });
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> More(int id)
        {
            var city = await _cityRepository.FirtsOrDefaoultAsync(c => c.Id == id);
            if (city == null)
            {
                return RedirectToAction("Index", "Cities");
            }

            var photos = await _photoRepositoty.FindByAsyn(p => p.CityId == id);
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
            var city = _cityRepository.GetListOrderBy(c => c.Name);
            return PartialView(city);
        }

        // GET: Cities/AllCitiesJson
        public ActionResult AllCitiesJson()
        {
            var city = _cityRepository.GetListOrderBy(c=>c.Name);
            return Json(city);
        }
    }
}