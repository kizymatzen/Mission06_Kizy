using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_Kizy.Models
{
    public class MovieApplicationContext : DbContext
    {
        private bool yes;

        //Constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options): base (options)
        {
            //Leave blank for now
        }
        
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                { 
                    ApplicationId = 1,
                    Category = "Action / Adventure",
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = " ",
                    Notes = " "
                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Action / Adventure",
                    Title = "Batman & Robin",
                    Year = 1997,
                    Director = "Joel Schumacher",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = " ",
                    Notes = " "

                },

                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Action / Adventure",
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = " ",
                    Notes = " "
                }

                );
        }
    }
}
