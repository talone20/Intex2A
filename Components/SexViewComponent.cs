using Intex2A.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Components
{
    public class SexViewComponent : ViewComponent
    {
        private IintexRepository repo { get; set; }

        public SexViewComponent(IintexRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
/*            ViewBag.SelectedSex = RouteData?.Values["sex"];

            var sexes = repo.Burial
                .Select(x => x.sex)
                .Distinct()
                .OrderBy(x => x);
*/
            return View();
        }
    }
}
