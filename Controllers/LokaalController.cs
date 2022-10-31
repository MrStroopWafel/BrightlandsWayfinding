using BrightlandsCasus.Data;
using Microsoft.AspNetCore.Mvc;

namespace BrightlandsCasus.Controllers
{
    public class LokaalController : Controller
    {
        private readonly ApplicationDbContext appDb;

        public LokaalController(ApplicationDbContext _appDb)
        {
            _appDb = appDb; 
        }
    }
}
