using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using KartApplication.Models; 

namespace KartverketWebApplication.Controllers
{
    public class AccountController : Controller
    {
       

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }


        public IActionResult VerifyEmail()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }


    }
}
