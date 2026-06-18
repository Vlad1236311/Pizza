using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
using Pizza.Data.Models;
using Pizza.ViewModels;
using System.Linq;

namespace Pizza.Controllers
{
    public class PizzaCartController : Controller
    {
        private readonly IAllFood _foodRep;
        private readonly PizzaCart _pizzaCart;

        public PizzaCartController(IAllFood foodRep, PizzaCart pizzaCart)
        {
            _foodRep = foodRep;
            _pizzaCart = pizzaCart;
        }

        public ViewResult Index()
        {
            var items = _pizzaCart.getPizzaItems();

            _pizzaCart.listPizzaItems = items;

            var obj = new PizzaCartViewModel
            {
                pizzaCart = _pizzaCart
            };

            return View(obj);
        }

        public IActionResult AddToCart(int id)
        {
            var item = _foodRep.Foods.FirstOrDefault(i => i.id == id);

            if (item != null)
            {
                _pizzaCart.AddToCart(item);
                TempData["Message"] = "🍕 Товар додано в кошик";
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            _pizzaCart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}