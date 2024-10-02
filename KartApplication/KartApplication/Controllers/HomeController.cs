using KartApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KartApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SubmitForm(FormModel model)
        {
            if (ModelState.IsValid)
            {
                // Form verilerini işle
                return RedirectToAction("FormResult", model);
            }
            return View("Index", model);
        }

        public IActionResult FormResult(FormModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
