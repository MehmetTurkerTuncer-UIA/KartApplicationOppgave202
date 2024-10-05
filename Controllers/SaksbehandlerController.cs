using Microsoft.AspNetCore.Mvc;

namespace KartApplication.Controllers
{
    public class SaksbehandlerController : Controller
    {
        // Saksbehandler giriş sayfası
        public IActionResult Index()
        {
            return View("Saksbehandler"); // Giriş sayfası (Saksbehandler.cshtml)
        }

        // Detay sayfası
        public IActionResult Detay(int id)
        {
            ViewBag.Id = id; // ID bilgisini view'e göndermek için
            return View();   // Detay.cshtml dosyasını döndürecek
        }
    }
}