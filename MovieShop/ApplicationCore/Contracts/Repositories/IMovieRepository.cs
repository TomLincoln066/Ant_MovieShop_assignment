﻿using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetTop30RevenueMovies();

        //Task<(IEnumerable<Movie>, int totalCount, int totalPages)> GetMoviesByGenres(int genreId, int pageSize = 30, int pageNumber = 1);
        Task<PagedResultSet<Movie>> GetMoviesByGenres(int genreId, int pageSize = 30, int pageNumber = 1);


    }
}
