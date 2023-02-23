using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_Kizy.Models
{
    public class MovieApplicationContext : DbContext
    {
        //Constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options): base (options)
        {
            //Leave blank for now
        }
        
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
 

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData
                (
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Animation" },
                new Category { CategoryId = 4, CategoryName = "Biography" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Crime" },
                new Category { CategoryId = 7, CategoryName = "Documentary" },
                new Category { CategoryId = 8, CategoryName = "Drama" },
                new Category { CategoryId = 9, CategoryName = "Family" },
                new Category { CategoryId = 10, CategoryName = "Fantasy" },
                new Category { CategoryId = 11, CategoryName = "Film Noir" },
                new Category { CategoryId = 12, CategoryName = "History" },
                new Category { CategoryId = 13, CategoryName = "Horror" },
                new Category { CategoryId = 14, CategoryName = "Music" },
                new Category { CategoryId = 15, CategoryName = "Musical" },
                new Category { CategoryId = 16, CategoryName = "Mystery" },
                new Category { CategoryId = 17, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 18, CategoryName = "Romance" },
                new Category { CategoryId = 19, CategoryName = "Sci-Fi" },
                new Category { CategoryId = 20, CategoryName = "Sport" },
                new Category { CategoryId = 21, CategoryName = "Superhero" },
                new Category { CategoryId = 22, CategoryName = "Television" },
                new Category { CategoryId = 23, CategoryName = "Thriller" },
                new Category { CategoryId = 24, CategoryName = "VHS" },
                new Category { CategoryId = 25, CategoryName = "War" },
                new Category { CategoryId = 26, CategoryName = "Western" },
                new Category { CategoryId = 27, CategoryName = "Action/Adventure" }
                );

            
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                { 
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title = "Avengers, The",
                    Year = 2011,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 2,
                    Title = "Batman & Robin",
                    Year = 1989,
                    Director = "Joel Schumacher",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                },

                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 3,
                    Title = "Batman Begins",
                    Year = 1997,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

                );
        }
    }
}
