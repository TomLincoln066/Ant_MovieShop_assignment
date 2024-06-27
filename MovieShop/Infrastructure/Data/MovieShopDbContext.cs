﻿using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MovieShopDbContext : DbContext
    {
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(ConfigureMovie);
        }

        private void ConfigureMovie(EntityTypeBuilder<Movie> builder) 
        {
            //Fluent API way
            //specify the rules for Movie Entity
            builder.ToTable("Movie");
            builder.HasKey(m=>m.Id);
            builder.Property(m => m.Title).HasMaxLength(256);

        
        }


    }
}
