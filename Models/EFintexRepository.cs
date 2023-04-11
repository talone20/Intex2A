using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    public class EFintexRepository : IintexRepository
    {
        private dataContext context { get; set; }

        public EFintexRepository(dataContext temp)
        {
            context = temp;
        }
        public IQueryable<PublicBurialmain> Burials => context.PublicBurialmain;
    }
}
