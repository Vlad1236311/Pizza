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
            var items = shopCart.getPizzaItems();
            shopCart.listPizzaItems = items;

            ViewBag.CartTotal = items.Sum(i => i.price);

            if (items == null || !items.Any())
            {
                TempData["Error"] = "Кошик порожній!";
                return RedirectToAction("Checkout");
            }

            try
            {
                order.orderTime = DateTime.Now;

                allOrders.createOrder(order);

                foreach (var item in items.ToList())
                {
                    shopCart.RemoveFromCart(item.food.id);
                }

                TempData["Success"] = "🎉 Замовлення успішно оформлено!";
                return RedirectToAction("Complete");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("Complete");
            }
        }


        public IActionResult Complete()
        {
            return View();
        }
    }
}