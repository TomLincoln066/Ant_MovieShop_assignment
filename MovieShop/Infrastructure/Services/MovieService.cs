using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMoviesService
    {
        public List<MovieCardModel> GetTop30GrossingMovies()
        {
            //call MovieRepository(call the database with Dapper or EF core)
            var movies = new List<MovieCardModel>()
            {
                new MovieCardModel {Id=1,PosterUrl="", Title="Inception"},
                new MovieCardModel {Id=2,PosterUrl="", Title="Interstellar"},
                new MovieCardModel {Id=3,PosterUrl="", Title="The Dark Knight"}

            };
            return movies;
        }
    }
}
