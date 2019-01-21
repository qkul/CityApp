using CitiesApp.Models;
using CitiesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
        public async Task<IActionResult> Index(string searchString)
        {
            var cities = _context.City.Select(x => x);
            if (!String.IsNullOrEmpty(searchString))
            {
                cities = cities.Where(s => s.Name.Contains(searchString));
            }
            return View(await _context.City.ToListAsync());
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
            var photos = _context.Photos.Where(p => p.CityId == id);
            if (city == null)
            {
                return RedirectToAction("Index", "Cities");
            }
            return View(new CityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                Photos = photos != null ? await photos.ToListAsync() : null
            });
        }

        public ActionResult AddPhoto(int? id)
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

            var photo = new Photo { CityId = model.CityId };
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

        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.Id == id);
        }
    }
}
