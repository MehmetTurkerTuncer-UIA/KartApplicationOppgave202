using Microsoft.AspNetCore.Mvc;

namespace KartApplication.Controllers
{
    public class BrukerController : Controller
    {
        public IActionResult Bruker()
        {
            return View();
        }
    }
}
