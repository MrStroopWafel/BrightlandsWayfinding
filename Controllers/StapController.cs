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
    public class StapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StapController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stap
        public async Task<IActionResult> Index(/*int? stappenConnectieId*/)
        {
            //if (stappenConnectieId != null)
            //{
            //    var appDbContext = _context.Stappen
            //        .Include(v => v.StapConnecties)
            //        .Where(o => o.stappenConnectieId == stappenConnectieId);
            //    return View(appDbContext.ToListAsync());
            //}
            //else
            //{
            //    var appDbContext = _context.Stappen.Include(o =>o.StapConnecties);
            //    return View(await appDbContext.ToListAsync());
            //}
              return View(await _context.Stappen.ToListAsync());
        }

        // GET: Stap/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stappen == null)
            {
                return NotFound();
            }

            var stap = await _context.Stappen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stap == null)
            {
                return NotFound();
            }

            return View(stap);
        }

        // GET: Stap/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StappenBeschrijving,lokaalId,stappenConnectieId")] Stap stap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stap);
        }

        // GET: Stap/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stappen == null)
            {
                return NotFound();
            }

            var stap = await _context.Stappen.FindAsync(id);
            if (stap == null)
            {
                return NotFound();
            }
            return View(stap);
        }

        // POST: Stap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StappenBeschrijving,lokaalId,stappenConnectieId")] Stap stap)
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

        // GET: Stap/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stappen == null)
            {
                return NotFound();
            }

            var stap = await _context.Stappen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stap == null)
            {
                return NotFound();
            }

            return View(stap);
        }

        // POST: Stap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stappen == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Stappen'  is null.");
            }
            var stap = await _context.Stappen.FindAsync(id);
            if (stap != null)
            {
                _context.Stappen.Remove(stap);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StapExists(int id)
        {
          return _context.Stappen.Any(e => e.Id == id);
        }
    }
}
