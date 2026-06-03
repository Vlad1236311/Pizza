using Pizza.Data.interfaces;
using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Data.mocks
{

        public class MockFood : IAllFood {

        private readonly IFoodCategory _categoryFood = new MockCategory();
        public IEnumerable<Food> Foods
            {
                get
                {
                    return new List<Food> {
                    new Food { 
                        name = "Піца Чотири Сири", 
                        shortDesc = "Сирна насолода", 
                        longDesc = "Піца з чотирма видами сиру: моцарела, горгонзола, пармезан та ементаль.", 
                        img = "", price = 150, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First()  
                    },
                    new Food { 
                        name = "Піца Пепероні", 
                        shortDesc = "Гостра класика", 
                        longDesc = "Піца з гострим салямі пепероні, томатним соусом та моцарелою.", 
                        img = "", 
                        price = 120, isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Вегетаріанська", 
                        shortDesc = "Овочева свіжість", 
                        longDesc = "Піца з різноманітними овочами: болгарський перець, гриби, оливки та цибуля.", 
                        img = "", price = 130, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Гавайська", 
                        shortDesc = "Тропічний смак", 
                        longDesc = "Піца з куркою, ананасами та моцарелою на томатному соусі.", 
                        img = "", price = 140, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Франческо", 
                        shortDesc = "Тропічний смак", 
                        longDesc = "Піца з куркою, ананасами та моцарелою на томатному соусі.", 
                        img = "", 
                        price = 140, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Coca Cola", 
                        shortDesc = "0.5 ", 
                        longDesc = "звичайна", 
                        img = "", 
                        price = 40, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.Last() },
                    new Food
                    {
                        name = "Піца Франческо",
                        shortDesc = "Фірмовий смак",
                        longDesc = "Піца з шинкою, печерицями, томатами та моцарелою на томатному соусі.",
                        img = "",
                        price = 140,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Чотири м'яса",
                        shortDesc = "Для справжніх м'ясоїдів",
                        longDesc = "Піца з шинкою, салямі, беконом, мисливськими ковбасками та моцарелою на томатному соусі.",
                        img = "",
                        price = 170,
                        isFavourite = true,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Маргарита",
                        shortDesc = "Класичний італійський смак",
                        longDesc = "Піца з томатним соусом, свіжими томатами, моцарелою та ароматним базиліком.",
                        img = "",
                        price = 120,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Трюфельна",
                        shortDesc = "Вишуканий аромат",
                        longDesc = "Піца з вершковим соусом, печерицями, моцарелою та трюфельною пастою.",
                        img = "",
                        price = 190,
                        isFavourite = true,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Карбонара",
                        shortDesc = "Ніжний вершковий смак",
                        longDesc = "Піца з вершковим соусом, беконом, моцарелою, пармезаном та яйцем.",
                        img = "",
                        price = 160,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                };
                }
            }
            public IEnumerable<Food> getFavFoods { get; set; }
           
            public Food getObjectFood(int foodId)
            {
               throw new NotImplementedException();
        }
        }
    }

