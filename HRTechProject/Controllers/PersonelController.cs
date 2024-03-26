using HRTechProject.Data;
using HRTechProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRTechProject.Controllers
{
    public class PersonelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonelController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Personel
        public async Task<IActionResult> Index()
        {
            var personeller = await _db.Personeller.ToListAsync();
            return View(personeller);
        }

        // GET: Personel/Details/id
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _db.Personeller.FirstOrDefaultAsync(m => m.Id == id);
            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }

        // GET: Personel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,Soyad,Email")] Personel personel)
        {
            if (ModelState.IsValid)
            {
                _db.Add(personel);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personel);
        }

        // GET: Personel/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _db.Personeller.FindAsync(id);
            if (personel == null)
            {
                return NotFound();
            }
            return View(personel);
        }

        // POST: Personel/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,Soyad,Email")] Personel personel)
        {
            if (id != personel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(personel);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelExists(personel.Id))
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
            return View(personel);
        }

        // GET: Personel/Delete/id
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personel = await _db.Personeller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personel == null)
            {
                return NotFound();
            }

            return View(personel);
        }

        // POST: Personel/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personel = await _db.Personeller.FindAsync(id);
            _db.Personeller.Remove(personel);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonelExists(int id)
        {
            return _db.Personeller.Any(e => e.Id == id);
        }
    }
}
