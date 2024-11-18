using EmployeeDotNet8.Data;
using EmployeeDotNet8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDotNet8.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoListController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Todolist.ToListAsync());
        }

        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> create(Todolist model)
        {
            if (ModelState.IsValid)
            {
                _context.Todolist.Add(model);
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
            var db = await _context.Todolist.FindAsync(id);
            if(db == null)
            {
                return BadRequest();
            }
            return View(db);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Todolist model)
        {
            if (ModelState.IsValid)
            {
                _context.Todolist.Update(model);
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
            var db = await _context.Todolist.FindAsync(id);
            if (db == null)
            {
                return NotFound();
            }

            _context.Todolist.Remove(db);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
