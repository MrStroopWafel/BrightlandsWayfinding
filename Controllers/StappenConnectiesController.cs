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
    public class StappenConnectiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StappenConnectiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StappenConnecties
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.StapConnectie.Include(s => s.StapFrom).Include(s => s.StapTo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: StappenConnecties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StapConnectie == null)
            {
                return NotFound();
            }

            var stapConnectie = await _context.StapConnectie
                .Include(s => s.StapFrom)
                .Include(s => s.StapTo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapConnectie == null)
            {
                return NotFound();
            }

            return View(stapConnectie);
        }

        // GET: StappenConnecties/Create
        public IActionResult Create()
        {
            ViewData["StapFromId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving");
            ViewData["StapToId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving");
            return View();
        }

        // POST: StappenConnecties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StapFromId,StapToId,Afstand,RouteUitelg")] StapConnectie stapConnectie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stapConnectie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StapFromId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapFromId);
            ViewData["StapToId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapToId);
            return View(stapConnectie);
        }

        // GET: StappenConnecties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StapConnectie == null)
            {
                return NotFound();
            }

            var stapConnectie = await _context.StapConnectie.FindAsync(id);
            if (stapConnectie == null)
            {
                return NotFound();
            }
            ViewData["StapFromId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapFromId);
            ViewData["StapToId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapToId);
            return View(stapConnectie);
        }

        // POST: StappenConnecties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StapFromId,StapToId,Afstand,RouteUitelg")] StapConnectie stapConnectie)
        {
            if (id != stapConnectie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stapConnectie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StapConnectieExists(stapConnectie.Id))
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
            ViewData["StapFromId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapFromId);
            ViewData["StapToId"] = new SelectList(_context.Stap, "Id", "StappenBeschrijving", stapConnectie.StapToId);
            return View(stapConnectie);
        }

        // GET: StappenConnecties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StapConnectie == null)
            {
                return NotFound();
            }

            var stapConnectie = await _context.StapConnectie
                .Include(s => s.StapFrom)
                .Include(s => s.StapTo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stapConnectie == null)
            {
                return NotFound();
            }

            return View(stapConnectie);
        }

        // POST: StappenConnecties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StapConnectie == null)
            {
                return Problem("Entity set 'ApplicationDbContext.StapConnectie'  is null.");
            }
            var stapConnectie = await _context.StapConnectie.FindAsync(id);
            if (stapConnectie != null)
            {
                _context.StapConnectie.Remove(stapConnectie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StapConnectieExists(int id)
        {
          return _context.StapConnectie.Any(e => e.Id == id);
        }
    }
}
