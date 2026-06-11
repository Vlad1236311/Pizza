using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int pizzaID { get; set; }
        public uint price { get; set; }
        public virtual Food pizza { get; set; }
        public virtual Order order { get; set; }
        

    }
}
