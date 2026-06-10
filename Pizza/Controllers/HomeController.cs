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
        private IAllFood _foodRep;

        public HomeController(IAllFood foodRep)
        {
            _foodRep = foodRep;
        }

        public ViewResult Index()
        {
            var homeFoods = new HomeViewModel {
            favFoods = _foodRep.getFavFoods
            };
            return View(homeFoods);
        }
    }
}
