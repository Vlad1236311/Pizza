using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Pizza.Data.interfaces;
using Pizza.Data.Models;

namespace Pizza.Data.Repository
{
    public class PizzaRepository : IAllFood
    {
        private readonly AppDBcontent appDBcontent;

        public PizzaRepository(AppDBcontent appDBcontent)
        {
            this.appDBcontent = appDBcontent;
        }

        public IEnumerable<Food> Foods => appDBcontent.Food.Include(c => c.Category);

        public IEnumerable<Food> getFavFoods => appDBcontent.Food.Where(p => p.isFavourite).Include(c => c.Category);
            
        public Food getObjectFood(int foodId) => appDBcontent.Food.FirstOrDefault(p => p.id == foodId);

    }
}
