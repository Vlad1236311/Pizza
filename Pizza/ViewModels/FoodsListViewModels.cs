using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.ViewModels
{
    public class FoodsListViewModels
    {
       public IEnumerable<Food> AllFoods { get; set; }  

       public string CurrentCategory { get; set; }

    }
	
}
