using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.ViewModels
{
    public class FoodsListViewModels
    {
       public IEnumerable<Food> allFoods { get; set; }  

       public string currCategory { get; set; }

    }
	
}
