using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;
using System.Diagnostics;
using ApplicationCore.Contracts.Services;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            //_movieService = new MovieService(); not the good way - concreate instantiate
            // instead we prefer 
            _movieService = movieService;


        }


        [HttpGet]
        public IActionResult Index()
        {

            //our controllers are very thin/lean
            //most of your logic should come from other dependencies, services
            //we create
            //

            //var movieService = new MovieService();

            //model data
            var movies= _movieService.GetTop30GrossingMovies();

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
