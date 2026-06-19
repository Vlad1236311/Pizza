using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data;
using Pizza.Data.Models;
using System.Linq;

namespace Pizza.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDBcontent db;

        public AdminController(AppDBcontent context)
        {
            db = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminLogin model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var admin = db.Admins.FirstOrDefault(a => a.Login == model.Login);

            if (admin != null)
            {
                var hasher = new PasswordHasher<Admin>();

                var result = hasher.VerifyHashedPassword(
                    admin,
                    admin.PasswordHash,
                    model.Password
                );

                if (result == PasswordVerificationResult.Success)
                {
                    HttpContext.Session.SetString("Admin", "true");
                    return RedirectToAction("Index", "AdminPanel");
                }
            }

            ModelState.AddModelError("", "Невірний логін або пароль");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login");
        }
    }
}