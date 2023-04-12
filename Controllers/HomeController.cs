using Intex2A.Models;
using Intex2A.Models.ViewModels;
using Intex2A.Models.PredictionModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IintexRepository repo;

        public HomeController(ILogger<HomeController> logger, IintexRepository temp)
        {
            repo = temp;
            _logger = logger;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BurialsViewModel
            {
                Burials = repo.Burials
                .OrderBy(x => x.Id)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBurials = repo.Burials.Count(),
                    BurialsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult PredictWrapping()
        {
            return View();
        }
        public IActionResult ScoreOutput(Prediction temp)
        {
            var prediction = temp;
            return View(prediction);
        }
    }
}
