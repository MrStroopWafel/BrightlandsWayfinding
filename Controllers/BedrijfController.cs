using BrightlandsCasus.Data;
using BrightlandsCasus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace BrightlandsCasus.Controllers
{
    public class BedrijfController : Controller
    {
        private readonly ApplicationDbContext appDb;
        public LokaalBedrijf lokaalBedrijf;
        public Bedrijf EditBedrijf;

        public BedrijfController(ApplicationDbContext _appDb)
        {
            appDb = _appDb;
        }

        [Authorize]
        public IActionResult BedrijvenOverzicht()
        {
            var Bedrijven = appDb.Bedrijven.ToList();
            ViewBag.bedrijven = Bedrijven;
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {

            return View();
        }


        public IActionResult Edit(int id)
        {
            var bedrijf = appDb.Bedrijven.Find(id);
            HttpContext.Session.SetString("BedrijfEditSession", JsonConvert.SerializeObject(bedrijf));

            var lokaal = appDb.Lokalen.ToList();
            ViewBag.lokalen = lokaal;

            return View(bedrijf);
        }

        [HttpPost]
        public IActionResult BedrijfEdit(Bedrijf bedrijf)
        {
            Bedrijf bed = JsonConvert.DeserializeObject<Bedrijf>(HttpContext.Session.GetString("BedrijfEditSession"));

            appDb.Bedrijven.Remove(bed);

            appDb.Bedrijven.Add(bedrijf);
            appDb.SaveChanges();

            return RedirectToAction("BedrijvenOverzicht");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var bedrijf = await appDb.Bedrijven.FindAsync(id);

            foreach (LokaalBedrijf lokaalBedrijf1 in appDb.lokaalBedrijf)
            {
                if (lokaalBedrijf1.LokaalId == bedrijf.Id)
                {
                    appDb.lokaalBedrijf.Remove(lokaalBedrijf1);
                }
            }

            appDb.Bedrijven.Remove(bedrijf);
            await appDb.SaveChangesAsync();
            return RedirectToAction("BedrijvenOverzicht");
        }

        public IActionResult Lokalen(int id)
        {
            var bedrijf = appDb.Bedrijven.Find(id);

            HttpContext.Session.SetString("BedrijfSession", JsonConvert.SerializeObject(bedrijf));

            var lokalen = appDb.lokaalBedrijf
                .Where(x => x.bedrijf.Id == id)
                .Include(x => x.lokaal);
            ViewBag.Lokalen = lokalen;
            return View();
        }

        [HttpPost]
        public IActionResult BedrijfPost(Bedrijf bedrijf)
        {
            appDb.Bedrijven
                .Add(bedrijf);
            appDb.SaveChanges();
            return RedirectToAction("BedrijvenOverzicht");
        }
    }
}
