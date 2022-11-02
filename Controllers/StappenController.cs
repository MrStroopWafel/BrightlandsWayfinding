using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BrightlandsCasus.Data;
using BrightlandsCasus.Models;

namespace BrightlandsCasus.Controllers
{
    public class StappenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StappenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stappen
        public async Task<IActionResult> Index()
        {
              return View(await _context.Stap.ToListAsync());
        }

        // GET: Stappen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stap == null)
            {
                return NotFound();
            }

            var stap = await _context.Stap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stap == null)
            {
                return NotFound();
            }

            return View(stap);
        }

        // GET: Stappen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stappen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StappenBeschrijving,LokaalId")] Stap stap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stap);
        }

        // GET: Stappen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stap == null)
            {
                return NotFound();
            }

            var stap = await _context.Stap.FindAsync(id);
            if (stap == null)
            {
                return NotFound();
            }
            return View(stap);
        }

        // POST: Stappen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StappenBeschrijving,LokaalId")] Stap stap)
        {
            if (id != stap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StapExists(stap.Id))
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
            return View(stap);
        }

        // GET: Stappen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stap == null)
            {
                return NotFound();
            }

            var stap = await _context.Stap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stap == null)
            {
                return NotFound();
            }

            return View(stap);
        }

        // POST: Stappen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stap == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Stap'  is null.");
            }
            var stap = await _context.Stap.FindAsync(id);
            if (stap != null)
            {
                _context.Stap.Remove(stap);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StapExists(int id)
        {
          return _context.Stap.Any(e => e.Id == id);
        }
    }
}
