using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            //our controllers are very thin/lean
            //most of your logic should come from other dependencies, services
            //we create
            //

            var movieService = new MovieService();

            //model data
            var movies= movieService.GetTop30GrossingMovies();

            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TopMovies()
        {
            return View("Privacy");//overload - you could specify which cshtml to direct to via parameters.
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
