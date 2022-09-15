using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie_4._0.Data;
using MvcMovie_4._0.Models;
using System.Diagnostics;

namespace MvcMovie_4._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcMovie_4_0Context _context;
                
        public HomeController(ILogger<HomeController> logger, MvcMovie_4_0Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAuswertungDaten()
        {
           
            // Teuerste Filme
            IQueryable<Movie> movies = from m in _context.Movie select m;

            List<Movie> movieList = movies.OrderByDescending(movie => movie.Price).ToList();
            
            return new JsonResult(movieList);
        }

        public IActionResult Auswertungen()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}