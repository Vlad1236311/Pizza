using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderId { get; set; }
        public Order order { get; set; }

        public int foodId { get; set; }
        public Food food { get; set; }

        public decimal price { get; set; }
    }
}
