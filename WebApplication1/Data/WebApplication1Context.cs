using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public DbSet<Models.Movie> Movie { get; set; }

        public WebApplication1Context(DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

       
    }
}
