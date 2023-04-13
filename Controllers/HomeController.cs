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
            var burials = repo.Burials.ToList<burialmain>();

            // Pass the list of objects to the view for display
            return View(burials);
        }
        
        public IActionResult Index()
        {
            return View();
        }

        //Get stuff
        [HttpGet]
        public IActionResult Edit(double id)
        {
           
            var burial = repo.Burials.FirstOrDefault(x => x.Id == id);
            if (burial == null)
            {
               return View("Summary");
            }
            
            return View(burial);
        }


        //Post stuff
        [HttpPost]
        public IActionResult Edit(double id, [Bind("Id,Squarenorthsouth,Headdirection,Sex,Northsouth,Depth,Eastwest,Adultsubadult,Facebundles,Southtohead,Preservation,Fieldbookpage,Squareeastwest,Goods,Text,Wrapping,Haircolor,Westtohead,Samplescollected,Area,Burialid,Length,Burialnumber,Dataexpertinitials,Westtofeet,Ageatdeath,Southtofeet,Excavationrecorder,Photos,Hair,Burialmaterials,Dateofexcavation,Fieldbookexcavationyear,Clusternumber,Shaftnumber")] PublicBurialmain burial)
        {
            if (ModelState.IsValid)
            {
                repo.SaveBurial(burial);
 
                return RedirectToAction(nameof(Summary));
            }
            return View(burial);
        }

        public IActionResult Delete ()
        {
            return View ();
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
