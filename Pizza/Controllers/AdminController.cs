using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data.Models;

namespace Pizza.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminLogin model)
        {
            if (model.Login == "admin" && model.Password == "12345")
            {
                HttpContext.Session.SetString("Admin", "true");

                return RedirectToAction("Index");
            }

            ViewBag.Error = "Неправильний логін або пароль";

            return View();
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login");

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Admin");

            return RedirectToAction("Login");
        }
    }
}