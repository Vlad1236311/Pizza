using Pizza.Data.interfaces;
using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.mocks
{
    public class MockCategory : IFoodCategory
    {
        public IEnumerable<Category> AllCategories {
            get { 
                return new List<Category> {
                    new Category {categoryName = "Піца", desc = "Всі види піци"},
                    new Category {categoryName = "Напої", desc = "Всі види напоїв"},
                    new Category {categoryName = "Комбо", desc = "Набори та комбо меню" }
                };
            }
        }
    }
}
