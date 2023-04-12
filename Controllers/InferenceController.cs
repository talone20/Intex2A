using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using Intex2A.Models.PredictionModels;
using System;

namespace Intex2A.Controllers
{
    [ApiController]
    [Route("Score")]
    public class InferenceController : ControllerBase
    {
        private InferenceSession _session;

        public InferenceController(InferenceSession session)
        {
            _session = session;
        }

        [HttpPost]
        public ActionResult Score([FromForm] ModelData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<string> score = result.First().AsTensor<string>();
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();

            return RedirectToAction("ScoreOutput", "Home", prediction);
        }
        [HttpGet]
        public ActionResult Score(Prediction prediction)
        {
            return RedirectToAction("Inference/PredictedScore", prediction);
        }

/*        private ActionResult PartialView(string v, Prediction prediction)
        {
            throw new NotImplementedException();
        }
*/
        /*        private ActionResult View(string v, Prediction prediction)
                {
                    throw new NotImplementedException();
                }*/
    }
}
