using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
using Pizza.Data.Models;
using Pizza.Data.Repository;
using Pizza.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Pizza.Controllers
{
    public class PizzaCartController : Controller
    {
        private IAllFood _foodRep;
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

        public RedirectToActionResult addToCart(int id) 
        {
        var item = _foodRep.Foods.FirstOrDefault(i => i.id == id);
         if(item != null)
            {
                _pizzaCart.AddToCart(item);
            }
            return RedirectToAction("Index");
            
        }


    }   
}
