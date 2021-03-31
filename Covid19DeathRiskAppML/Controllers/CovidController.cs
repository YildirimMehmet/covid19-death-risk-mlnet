using Covid19DeathRiskAppML.Models;
using Covid19DeathRiskAppMLML.Model;
using Microsoft.AspNetCore.Mvc;

namespace Covid19DeathRiskAppML.Controllers
{
    public class CovidController : Controller
    {
        [HttpGet]
        public IActionResult DeathRisk()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeathRisk(DeathRiskRequest request)
        {
            ModelInput input = new ModelInput
            {
                Age_Years = $"{request.Age} Years",
                Sex = request.Gender.ToString()
            };

            var predictionResult = ConsumeModel.Predict(input);
            ViewBag.Result = predictionResult;
            return View();
        }

    }
}
