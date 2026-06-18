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

        public IActionResult Index(string category, ushort? minPrice,
                          ushort? maxPrice, string sortOrder)
        {
            var foods = _foodRep.Foods.AsQueryable();

            // 🔥 КАТЕГОРІЯ (ВАЖЛИВО: без null проблем)
            if (!string.IsNullOrEmpty(category))
            {
                foods = foods.Where(x => x.Category != null &&
                                         x.Category.categoryName == category);
            }

            // 🔥 ЦІНА
            if (minPrice.HasValue && maxPrice.HasValue)
            {
                if (minPrice > maxPrice)
                {
                    ViewBag.Error = "Мінімальна ціна не може бути більшою за максимальну.";
                }
                else
                {
                    foods = foods.Where(x =>
                        x.price >= minPrice &&
                        x.price <= maxPrice);
                }
            }

            // 🔥 СОРТУВАННЯ
            switch (sortOrder)
            {
                case "asc":
                    foods = foods.OrderBy(x => x.price);
                    break;

                case "desc":
                    foods = foods.OrderByDescending(x => x.price);
                    break;
            }

            return View(new HomeViewModel
            {
                Foods = foods.ToList()
            });
        }
    }
}
