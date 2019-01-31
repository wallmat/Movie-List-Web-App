using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFristWebApplication.Models
{
    public class MyFristWebApplicationContext : DbContext
    {
        public MyFristWebApplicationContext (DbContextOptions<MyFristWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MyFristWebApplication.Models.Movie> Movie { get; set; }
    }
}
