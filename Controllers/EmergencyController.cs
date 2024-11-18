using EmployeeDotNet8.Data;
using EmployeeDotNet8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDotNet8.Controllers
{
    public class EmergencyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmergencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _context.emergencies.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Emergency model)
        {
            if (ModelState.IsValid)
            {
                _context.emergencies.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var db = await _context.emergencies.FindAsync(id);
            if (db == null)
            {
                return BadRequest();
            }
            return View(db);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Emergency model)
        {
            if (ModelState.IsValid)
            {
                _context.emergencies.Update(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var db = await _context.emergencies.FindAsync(id);

            if(db == null)
            {
                return NotFound();
            }

            _context.emergencies.Remove(db);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
