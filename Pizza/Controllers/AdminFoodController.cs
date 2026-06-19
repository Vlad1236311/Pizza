using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pizza.Data;
using Pizza.Data.Models;
using System.Linq;

namespace Pizza.Controllers
{
    public class AdminFoodController : Controller
    {
        private readonly AppDBcontent db;

        public AdminFoodController(AppDBcontent context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            return View(db.Food.ToList());
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = db.Category.ToList();
            return View(db.Food.FirstOrDefault(x => x.id == id));
        }

        [HttpPost]
        public IActionResult Edit(Food food)
        {
            var oldFood = db.Food.FirstOrDefault(x => x.id == food.id);

            if (oldFood != null)
            {
                // перевірка categoryID (ВАЖЛИВО)
                var categoryExists = db.Category.Any(c => c.id == food.categoryID);

                if (!categoryExists)
                {
                    TempData["Error"] = "Невірна категорія!";
                    return RedirectToAction("Index");
                }

                oldFood.name = food.name;
                oldFood.shortDesc = food.shortDesc;
                oldFood.longDesc = food.longDesc;
                oldFood.price = food.price;
                oldFood.img = food.img;
                oldFood.isFavourite = food.isFavourite;
                oldFood.available = food.available;
                oldFood.categoryID = food.categoryID;

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Hide(int id)
        {
            var food = db.Food.FirstOrDefault(x => x.id == id);

            if (food != null)
            {
                food.available = false;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Show(int id)
        {
            var food = db.Food.FirstOrDefault(x => x.id == id);

            if (food != null)
            {
                food.available = true;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}