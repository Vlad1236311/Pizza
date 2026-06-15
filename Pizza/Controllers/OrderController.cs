using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
using Pizza.Data.Models;

namespace Pizza.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly PizzaCart shopCart;

        public OrderController(IAllOrders allOrders, PizzaCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            shopCart.listPizzaItems = shopCart.getPizzaItems();

            ViewBag.CartTotal = shopCart.listPizzaItems.Sum(i => i.price);

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listPizzaItems = shopCart.getPizzaItems();

            ViewBag.CartTotal = shopCart.listPizzaItems.Sum(i => i.price);

            if (shopCart.listPizzaItems.Count == 0)
            {
                ModelState.AddModelError("", "Кошик порожній!");
            }

            if (ModelState.IsValid)
            {
                order.orderTime = DateTime.Now;
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }


        public IActionResult Complete()
        {
            TempData["Message"] = "🎉 Замовлення успішно оформлено!";
            return RedirectToAction("Complete");
        }
    }
}