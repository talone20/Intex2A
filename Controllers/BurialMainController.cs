using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    public class BurialMainController : ControllerBase
    {
        private readonly IntexDbContext _context;

        public BurialMainController(IntexDbContext context)
        {
            _context = context;
        }
    }
}
