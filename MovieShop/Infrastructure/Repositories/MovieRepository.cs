using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetTop30RevenueMovies() 
        {

            // EF Core or Dapper
            // They provide both sync and async methods in those libraries
            //get top 30 movies by revenue
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetById(int id)
        {
            //First
            //Single
            //FirstOrDefault
            //SingleOrDefault
            //we need to use Include method
            var movieDetails = await _dbContext.Movies.Include(m => m.Genres).ThenInclude(m => m.Genre)
                .Include(m=>m.MovieCasts).ThenInclude(m=>m.Cast)
                .Include(m => m.Trailers)
                .FirstOrDefaultAsync(m => m.Id == id);
            return movieDetails;
        }


    }
}
