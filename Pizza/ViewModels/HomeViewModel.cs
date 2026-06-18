using Pizza.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Food> Foods { get; set; }
    }
}
