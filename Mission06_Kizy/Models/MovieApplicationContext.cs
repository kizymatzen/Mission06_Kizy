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
        
        public DbSet<ApplicationResponse> responses { get; set; }
    }
}
