using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pizza.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            return View();
        }
    }
}
