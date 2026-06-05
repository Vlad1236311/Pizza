using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza.Data.interfaces;
using Pizza.Data.Models;

namespace Pizza.Data.Repository
{
    public class CategoryRepository : IFoodCategory
    {

        private readonly AppDBcontent appDBcontent;

        public CategoryRepository(AppDBcontent appDBcontent)
        {
            this.appDBcontent = appDBcontent;
        }
        public IEnumerable<Category> AllCategories => appDBcontent.Category;
    }
}
