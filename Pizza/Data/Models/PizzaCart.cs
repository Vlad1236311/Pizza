using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.Models
{
    public class PizzaCart
    {
        private readonly AppDBcontent appDBcontent;

        public PizzaCart(AppDBcontent appDBcontent)
        {
            this.appDBcontent = appDBcontent;
        }

        public string PizzaCartId { get; set; }

        public List<PizzaCartItem> listPizzaItems { get; set; }

        public static PizzaCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBcontent>();
            string pizzaCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", pizzaCartId);

            return new PizzaCart(context) { PizzaCartId = pizzaCartId };
        }

        public void AddToCart(Food food) 
        {
            appDBcontent.PizzaCartItem.Add(new PizzaCartItem{
                PizzaCartId = PizzaCartId,
                food = food,
                price = food.price
            });

            appDBcontent.SaveChanges();
        }

        public List<PizzaCartItem> getPizzaItems() 
        {
            return appDBcontent.PizzaCartItem.Where(c => c.PizzaCartId == PizzaCartId).Include(s => s.food).ToList();
        } 

    }
}
