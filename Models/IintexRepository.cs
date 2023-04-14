using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Models
{
    public interface IintexRepository
    {
        IQueryable<burialmain> Burials { get; }

        void CreateBurial(burialmain burial);

        void UpdateBurial(burialmain burial);

        void DeleteBurial(double burialId);
    }
}
