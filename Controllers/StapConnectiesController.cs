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
    public class StapConnectiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StapConnectiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StapConnecties
        public async Task<IActionResult> Index()
        {
              return View(await _context.StapConnecties.ToListAsync());
        }

        // GET: StapConnecties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StapConnecties == null)
            {
                return NotFound();
            }

            var stapConnecties = await _context.StapConnecties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapConnecties == null)
            {
                return NotFound();
            }

            return View(stapConnecties);
        }

        // GET: StapConnecties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StapConnecties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,vanId")] StapConnecties stapConnecties)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stapConnecties);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stapConnecties);
        }

        // GET: StapConnecties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StapConnecties == null)
            {
                return NotFound();
            }

            var stapConnecties = await _context.StapConnecties.FindAsync(id);
            if (stapConnecties == null)
            {
                return NotFound();
            }
            return View(stapConnecties);
        }

        // POST: StapConnecties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,vanId")] StapConnecties stapConnecties)
        {
            if (id != stapConnecties.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stapConnecties);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StapConnectiesExists(stapConnecties.Id))
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
            return View(stapConnecties);
        }

        // GET: StapConnecties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StapConnecties == null)
            {
                return NotFound();
            }

            var stapConnecties = await _context.StapConnecties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapConnecties == null)
            {
                return NotFound();
            }

            return View(stapConnecties);
        }

        // POST: StapConnecties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StapConnecties == null)
            {
                return Problem("Entity set 'ApplicationDbContext.StapConnecties'  is null.");
            }
            var stapConnecties = await _context.StapConnecties.FindAsync(id);
            if (stapConnecties != null)
            {
                _context.StapConnecties.Remove(stapConnecties);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StapConnectiesExists(int id)
        {
          return _context.StapConnecties.Any(e => e.Id == id);
        }
    }
}
