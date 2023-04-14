using Intex2A.Models;
using Intex2A.Models.ViewModels;
using Intex2A.Models.PredictionModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace Intex2A.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IintexRepository repo;

        public HomeController(/*ILogger<HomeController> logger, */IintexRepository temp)
        {
            repo = temp;
/*            _logger = logger;*/
        }

        public IActionResult Summary(/*int pageNum = 1*/)
        {
            /*int pageSize = 10;*/


            // Execute the query and store the results in a list of objects
            var burials = repo.Burials.
                OrderBy(x => x.id).
                ToList<burialmain>();

            // Pass the list of objects to the view for display
            return View(burials);
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateBurial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBurial(burialmain burial)
        {
            if (burial == null)
            {
                return NotFound();
            }

            repo.CreateBurial(burial);

            return View("Summary");
        }
        [HttpGet]
        public IActionResult Edit(double burialId)
        {
            var burial = repo.Burials.FirstOrDefault(x => x.id == burialId);

            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }
        [HttpPost]
        public IActionResult Edit(burialmain burial)
        {

            if (burial == null)
            {
                return NotFound();
            }

            repo.UpdateBurial(burial);

            ViewData["Message"] = "Record updated successfully.";

            return View(burial);
        }

        [HttpGet]
        public IActionResult Delete(double burialId)
        {
            var burial = repo.Burials.FirstOrDefault(x => x.id == burialId);

            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        [HttpGet]
        public IActionResult ConfirmDelete(double burialId)
        {

            repo.DeleteBurial(burialId);

            return RedirectToAction("Summary");
        }

        [Authorize]
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
