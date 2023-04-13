using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    public interface IintexRepository
    {
        IQueryable<PublicBurialmain> Burials { get; }

        public void SaveBurial(PublicBurialmain burial);
    }
}
