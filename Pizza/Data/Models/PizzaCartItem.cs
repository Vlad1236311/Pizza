using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace Pizza.Data.Models
{
    public class PizzaCartItem
    {
        public int id { get; set; }

        public Food food { get; set; }

        public string PizzaCartId { get; set; }

        public int quantity { get; set; } = 1;

        public double price { get; set; }
    }
}
