using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    [ApiController]
    public class EFintexRepository : IintexRepository
    {
        private IntexDbContext context { get; set; }

        public EFintexRepository(IntexDbContext temp)
        {
            context = temp;
        }
        public IQueryable<BurialMain> Burials => context.Burials;
    }
}
