using EmployeeDotNet8.Data;
using EmployeeDotNet8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static EmployeeDotNet8.Models.Employee;

namespace EmployeeDotNet8.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        public IActionResult AddEmployees()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEmployees(Employee model)
        {
            if (ModelState.IsValid)
            {
               _context.Employees.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var db = await _context.Employees.FindAsync(id);
            if (db == null)
            {
                return NotFound();
            }
            return View(db);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var db = await _context.Employees.FindAsync(id);
            if (db == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(db);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
