using Microsoft.AspNetCore.Mvc;
using KartApplication.Data;
using KartApplication.Models;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitForm(FormModel model)
    {
        if (ModelState.IsValid)
        {
            // Veritabanına form verilerini kaydet
            var location = new Location
            {
                Name = model.Name,
                Email = model.Email,
                Latitude = model.Latitude,
                Longitude = model.Longitude
            };

            _context.Locations.Add(location);
            _context.SaveChanges();

            return RedirectToAction("FormResult", model);
        }

        return View("Index", model);
    }

    public IActionResult FormResult(FormModel model)
    {
        return View(model);
    }
}
