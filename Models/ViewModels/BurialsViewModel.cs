using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models.ViewModels
{
    public class BurialsViewModel
    {
        public IQueryable<burialmain> Burials { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
