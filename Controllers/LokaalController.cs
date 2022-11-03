using BrightlandsCasus.Data;
using BrightlandsCasus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BrightlandsCasus.Controllers
{
    public class LokaalController : Controller
    {
        private readonly ApplicationDbContext appDb;

        public LokaalController(ApplicationDbContext _appDb)
        {
            appDb = _appDb; 
        }

        [Authorize]
        public IActionResult KiesVerdieping()
        {
            var verdieping = appDb.Verdiepingen.ToList();

            ViewBag.verdiepingen = verdieping;
            return View();
        }

        public IActionResult VerdiepingLokaal(int id)
        {
            Verdieping verdieping = appDb.Verdiepingen.Find(id); 

            HttpContext.Session.SetString("VerdiepingSession", JsonConvert.SerializeObject(verdieping));


            var lokaal = appDb.Lokalen
                .Where(x => x.VerdiepingId == id)
                .ToList();

            ViewBag.lokalen = lokaal;

            return View();
        }

        [Authorize]
        public IActionResult LokaalCreate()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult LokaalPost(Lokaal lokaal)
        {
            Verdieping ver = JsonConvert.DeserializeObject<Verdieping>(HttpContext.Session.GetString("VerdiepingSession"));

            lokaal.VerdiepingId = ver.Id;  

            appDb.Lokalen
                .Add(lokaal);
            appDb.SaveChanges(); 
            return RedirectToAction("VerdiepingLokaal","Lokaal", new {id = ver.Id});
        }
    }
}