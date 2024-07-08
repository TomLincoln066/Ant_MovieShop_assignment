﻿using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers 
{
    public class MoviesController : Controller
    { 



        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Details(int id)
        {
            // Movie Service with Details  
            // pass the movie details data to view
            var moviedetails = await _movieService.GetMovieDatails(id);
            return View(moviedetails);
        }
    }
}

