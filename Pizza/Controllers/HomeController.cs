using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
using Pizza.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllFood _foodRep;

        public HomeController(IAllFood foodRep)
        {
            _foodRep = foodRep;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Foods = _foodRep.Foods.ToList()
            };

            return View(model);
        }
    }
}
