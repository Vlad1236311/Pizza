using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza.Data.Models;

namespace Pizza.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);

    }
}
