using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.interfaces
{
    public interface IAllFood
    {
        IEnumerable<Food> Foods { get;  }
        IEnumerable<Food> getFavFoods { get; }
        Food getObjectFood(int foodId);
    }
}
