using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.Data.interfaces;
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

		public ViewResult List()
		{
            ViewBag.Title = "Сторінка з їжею";
            FoodsListViewModels obj = new FoodsListViewModels();
			obj.allFoods = _allFood.Foods;
			obj.currCategory = "Піца";
			obj.currCategory = "Напої";

            return View(obj);
		}

    }

}
