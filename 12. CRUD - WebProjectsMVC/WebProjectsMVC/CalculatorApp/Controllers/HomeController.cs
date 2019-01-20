using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();
            CalculatorsHistory.Calculators.Add(calculator);
            return RedirectToAction("Index", calculator);
        }

        public IActionResult History()
        {
            return View(CalculatorsHistory.Calculators);
        }
    }
}
