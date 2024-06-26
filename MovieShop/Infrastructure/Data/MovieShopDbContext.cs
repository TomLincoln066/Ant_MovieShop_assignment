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


            /*  builder.ToTable("Movie");
              builder.HasKey(m => m.Id);
              builder.Property(m => m.Title).HasMaxLength(256);*/



                builder.HasKey(m => m.Id);
                builder.Property(m => m.Title).HasMaxLength(256);
                builder.Property(m => m.Overview).HasMaxLength(4096);
                builder.Property(m => m.Tagline).HasMaxLength(512);
                builder.Property(m => m.ImbdUrl).HasMaxLength(2084);
                builder.Property(m => m.TmdbUrl).HasMaxLength(2084);
                builder.Property(m => m.PosterUrl).HasMaxLength(2084);
                builder.Property(m => m.BackDropUrl).HasMaxLength(2084);
                builder.Property(m => m.OriginalLanguage).HasMaxLength(64);
                builder.Property(m => m.UpdatedBy).HasMaxLength(512);
                builder.Property(m => m.CreatedBy).HasMaxLength(512);

                builder.Property(m => m.Price).HasColumnType("decimal(5, 2)").HasDefaultValue(9.9m);
                builder.Property(m => m.Budget).HasColumnType("decimal(18, 4)").HasDefaultValue(9.9m);
                builder.Property(m => m.Revenue).HasColumnType("decimal(18, 4)").HasDefaultValue(9.9m);

                builder.Property(m => m.CreatedDate).HasDefaultValueSql("getdate()");

                builder.Ignore(m => m.Rating);

                builder.HasIndex(m => m.Title);
                builder.HasIndex(m => m.Price);
                builder.HasIndex(m => m.Revenue);
                builder.HasIndex(m => m.Budget);



        }


    }
}
