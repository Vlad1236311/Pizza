using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
using Pizza.Data.Models;
using Pizza.ViewModels;


namespace Pizza.Controllers
{
	public class FoodController : Controller 
	{
		private readonly IAllFood _allFood;
        private readonly IFoodCategory _allCategories;

		public FoodController(IAllFood iAllFood, IFoodCategory iFoodCategory)
		{

			_allFood = iAllFood;
			_allCategories = iFoodCategory;
		}

		[Route("Food/List")]
        [Route("Food/List/{category}")]
        public ViewResult List(string category)
		{
			string _category = category;
            IEnumerable<Food> foods = null;
			string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                foods = _allFood.Foods
                                .Where(i => i.available)
                                .OrderBy(i => i.id);
            }
            else
			{
				if (string.Equals("Pizza", category, StringComparison.OrdinalIgnoreCase)) {
                    foods = _allFood.Foods.Where(i => i.available &&i.Category.categoryName.Equals("Піца")).OrderBy(i => i.id);
                }
                else if (string.Equals("Drink", category, StringComparison.OrdinalIgnoreCase))
                {
                    foods = _allFood.Foods.Where(i => i.available &&i.Category.categoryName.Equals("Напої")).OrderBy(i => i.id);
                }
                else if (string.Equals("Combo", category, StringComparison.OrdinalIgnoreCase))
                {
                    foods = _allFood.Foods.Where(i => i.available &&i.Category.categoryName.Equals("Комбо")).OrderBy(i => i.id);
                }
            }

			var foodObj = new FoodsListViewModels
			{
				allFoods = foods,
				currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з їжею";
            return View(foodObj);
		}

    }

}
