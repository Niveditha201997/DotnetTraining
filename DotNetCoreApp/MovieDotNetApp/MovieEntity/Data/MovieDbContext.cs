using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MovieEntity.Models;

namespace MovieEntity.Data
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> movies { get; set; }
        public DbSet<Theatre> theatre { get; set; }
        public DbSet<ShowTimings> showTimings { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data source=VDC01LTC2013;Initial Catalog=BookMyShowDb; Integrated Security=True;");
        }
    }
}
