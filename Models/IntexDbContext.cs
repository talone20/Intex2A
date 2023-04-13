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
        private readonly IConfiguration _configuration;
        public IntexDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

        public IntexDbContext(DbContextOptions<IntexDbContext> options)
            : base(options)
        {
        }

        public DbSet<BurialMain> Burials { get; set; }

    }
}