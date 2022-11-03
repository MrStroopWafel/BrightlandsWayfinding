using BrightlandsCasus.Data;
using BrightlandsCasus.Models;
using Humanizer;
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
            List<Lokaal> FindLokaal = appDb.Lokalen.ToList(); 
            
            
            //Lokalen die al aan een bedrijf gekoppeld zijn worden uit de lijst verwijderd. 
            foreach (LokaalBedrijf lokaalBedrijf in appDb.lokaalBedrijf)
            {
                foreach (Lokaal lokaal in appDb.Lokalen)
                {
                    if (lokaal.Id == lokaalBedrijf.LokaalId)
                    {
                        FindLokaal.Remove(lokaal);
                    }
                }
            }

            var Lokalen = (from Lokaal in FindLokaal
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
