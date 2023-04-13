using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    public class IntexDbContext : DbContext
    {

        public IntexDbContext()
        {
        }

        public IntexDbContext(DbContextOptions<IntexDbContext> options)
            : base(options)
        {
        }

        public DbSet<burialmain> Burials { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("DefaultConnection");
            }
        }

    }
}