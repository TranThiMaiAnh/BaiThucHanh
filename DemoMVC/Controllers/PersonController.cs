using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
// 2021050093-tran thi mai anh
namespace DemoMVC.Controllers
{
    public class PersonController:Controller
{
     private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FullName,Age,Address")] Person ps)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ps);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ps);
        }


        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Person == null)
            {
                return NotFound();
            }

            var ps = await _context.Person.FindAsync(id);
            if (ps == null)
            {
                return NotFound();
            }
            return View(ps);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,FullName,Age,Address")] Person ps)
        {
            if (id != ps.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ps);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(ps.PersonID))
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
            return View(ps);
        }


        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Person == null)
            {
                return NotFound();
            }

            var ps = await _context.Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (ps == null)
            {
                return NotFound();
            }

            return View(ps);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Person == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Person'  is null.");
            }
            var ps = await _context.Person.FindAsync(id);
            if (ps != null)
            {
                _context.Person.Remove(ps);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(string id)
        {
          return (_context.Person?.Any(e => e.PersonID == id)).GetValueOrDefault();
        }

         public async Task<IActionResult> Index()
        {
              return _context.Person != null ? 
                          View(await _context.Person.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Person'  is null.");
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Person == null)
            {
                return NotFound();
            }

            var ps = await _context.Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (ps == null)
            {
                return NotFound();
            }

            return View(ps);
        }

    }


}
