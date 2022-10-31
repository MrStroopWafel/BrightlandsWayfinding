using BrightlandsCasus.Data;
using BrightlandsCasus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;

namespace BrightlandsCasus.Controllers
{
    public class LokaalBedrijfController : Controller
    {
        private readonly ApplicationDbContext appDb;
        public LokaalBedrijf lokaalBedrijf1;
        public LokaalBedrijfController(ApplicationDbContext _appDb)
        {
            appDb = _appDb;
        }
        public IActionResult LokalenToevoegen(int id)
        {
            var Lokalen = (from Lokaal in appDb.Lokalen
                           select new SelectListItem()
                           {
                               Text = Lokaal.LokaalNummer,
                               Value = Lokaal.LokaalNummer
                           }).ToList();
            Lokalen.Insert(0, new SelectListItem()
            {
                Text = "Kies een Lokaal...",
                Value = String.Empty
            });


            ViewBag.lokalen = Lokalen;

            return View();
        }


        [HttpPost]
        public IActionResult LokaalBedrijfPost(LokaalBedrijf lokaalBedrijf)
        {
            Bedrijf bedrijf = JsonConvert.DeserializeObject<Bedrijf>(HttpContext.Session.GetString("BedrijfSession"));

            lokaalBedrijf.BedijfId = bedrijf.Id;



            foreach (Lokaal lokaal in appDb.Lokalen)
            {
                if (lokaalBedrijf.LokaalNummer == lokaal.LokaalNummer)
                {
                    lokaalBedrijf.LokaalId = lokaal.Id;
                }
            }



            appDb.lokaalBedrijf
                .Add(lokaalBedrijf);
            appDb.SaveChanges();
            return RedirectToAction("BedrijvenOverzicht", "Bedrijf");
        }
    }
}
