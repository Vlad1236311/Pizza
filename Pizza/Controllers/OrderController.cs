using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data;
using Pizza.Data.interfaces;
using Pizza.Data.Models;

namespace Pizza.Controllers
{
    public class OrderController : Controller {

        private readonly IAllOrders allOrders;
        private readonly PizzaCart shopCart;

        public OrderController(IAllOrders allOrders, PizzaCart shopCart) {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order) {

            shopCart.listPizzaItems = shopCart.getPizzaItems();

            if (shopCart.listPizzaItems.Count == 0) {
                ModelState.AddModelError("", "У вас повинна бути хоча б одна піца!");
            }

            if (ModelState.IsValid) {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete() {
            ViewBag.Message = "Замовлення успішно оброблено!";
            return View();
        }

    }
}
