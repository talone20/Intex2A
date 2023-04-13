using Intex2A.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Components
{
    public class WrappingViewComponent : ViewComponent
    {
        private IintexRepository repo { get; set; }

        public WrappingViewComponent (IintexRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
 /*           ViewBag.SelectedWrapping = RouteData?.Values["wrapping"];

            var wrappings = repo.Burials
                .Select(x => x.wrapping)
                .Distinct()
                .OrderBy(x => x);
*/
            return View();
        }
    }
}
