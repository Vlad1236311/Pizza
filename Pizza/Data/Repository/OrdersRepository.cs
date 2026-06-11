using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza.Data.interfaces;
using Pizza.Data.Models;

namespace Pizza.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBcontent appDBcontent;
        private readonly PizzaCart shopCart;

        public OrdersRepository(AppDBcontent appDBcontent, PizzaCart shopCart)
        {
            this.appDBcontent = appDBcontent;
            this.shopCart = shopCart;
        }

        public void createOrder(Models.Order order)
        {
            order.orderTime = DateTime.Now;
            appDBcontent.Order.Add(order);
            appDBcontent.SaveChanges();


            var items = shopCart.listPizzaItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    pizzaID = el.food.id, 
                    orderID = order.id,
                    price = el.food.price 
                };
                appDBcontent.OrderDetail.Add(orderDetail);

            }
            appDBcontent.SaveChanges();
        }
    }
}