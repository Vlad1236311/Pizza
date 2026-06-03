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
                        img = "/img/syrov.jpg", price = 340, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First()  
                    },
                    new Food { 
                        name = "Піца Пепероні", 
                        shortDesc = "Гостра класика", 
                        longDesc = "Піца з гострим салямі пепероні, томатним соусом та моцарелою.", 
                        img = "/img/pepperony.jpg", 
                        price = 325, isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Чікен Песто",
                        shortDesc = "Курка та ароматний соус песто",
                        longDesc = "Піца з ніжним курячим філе, соусом песто, сиром моцарела та свіжими травами, що створюють насичений і ароматний смак.",
                        img = "/img/vegan.jpg", price = 369, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Гавайська", 
                        shortDesc = "Тропічний смак", 
                        longDesc = "Піца з куркою, ананасами та моцарелою на томатному соусі.", 
                        img = "/img/havaiska.jpg", price = 341, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },
                    new Food { 
                        name = "Піца Діабло",
                        shortDesc = "Гостра піца з характером",
                        longDesc = "Піца з гострою салямі, перцем чилі, томатним соусом та сиром моцарела для тих, хто любить пекучий смак.", 
                        img = "/img/diablo.jpg", 
                        price = 364, 
                        isFavourite = false, 
                        available = true, 
                        Category = _categoryFood.AllCategories.First() 
                    },

                    new Food
                    {
                        name = "Піца Екстраваганзa",
                        shortDesc = "Максимум смаку в кожному шматку",
                        longDesc = "Ситна піца з різними видами м’яса, овочами, сиром та фірмовим соусом — справжнє поєднання всіх улюблених інгредієнтів.",
                        img = "/img/extravaganzza.jpg",
                        price = 385,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца з грушею і блакитним сиром",
                        shortDesc = "Солодко-солоний делікатес",
                        longDesc = "Піца з соковитою грушею, блакитним сиром та медовими нотками для вишуканого гастрономічного досвіду.",
                        img = "/img/pieces.jpg",
                        price = 329,
                        isFavourite = true,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Маргарита",
                        shortDesc = "Класичний італійський смак",
                        longDesc = "Піца з томатним соусом, свіжими томатами, моцарелою та ароматним базиліком.",
                        img = "/img/marharyta.jpg",
                        price = 314,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Шпинат і Фета",
                        shortDesc = "Легка та середземноморська",
                        longDesc = "Піца зі свіжим шпинатом, сиром фета, оливковою олією та моцарелою, що створює ніжний і збалансований смак.",
                        img = "/img/shpynatfeta.jpg",
                        price = 340,
                        isFavourite = true,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Піца Карбонара",
                        shortDesc = "Ніжний вершковий смак",
                        longDesc = "Піца з вершковим соусом, беконом, моцарелою, пармезаном та яйцем.",
                        img = "/img/karbonara.jpg",
                        price = 285,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food
                    {
                        name = "Піца Барбекю",
                        shortDesc = "Димний смак BBQ м’яса",
                        longDesc = "Піца з куркою або м’ясом у соусі барбекю, цибулею, сиром моцарела та легкими димними нотками для насиченого смаку.",
                        img = "/img/bbq.jpg",
                        price = 325,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food
                    {
                        name = "Піца Лосось Філадельфія",
                        shortDesc = "Ніжний лосось та крем-сир",
                        longDesc = "Піца з копченим лососем, крем-сиром Філадельфія, моцарелою та легким соусом, що створює ніжний і вишуканий смак.",
                        img = "/img/salmon.jpg",
                        price = 388,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food {
                        name = "Coca Cola",
                        shortDesc = "0.500 мл",
                        longDesc = "звичайна",
                        img = "/img/cola-claccic.jpg",
                        price = 68,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.Last() },
                    new Food
                    {
                        name = "Coca Cola Zero",
                        shortDesc = "0.500 мл",
                        longDesc = "без цукру",
                        img = "/img/cola-cola zero .jpg",
                        price = 68,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food
                    {
                        name = "Fanta",
                        shortDesc = "0.500 мл",
                        longDesc = "апельсин",
                        img = "/img/Fanta.jpg",
                        price = 57,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                                        new Food
                    {
                        name = "Sprite",
                        shortDesc = "0.500 мл",
                        longDesc = "газований",
                        img = "/img/Sprite.jpg",
                        price = 57,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food
                    {
                        name = "Schweppes",
                        shortDesc = "0.330 мл",
                        longDesc = "indian tonic",
                        img = "/img/Schweppes indian tonic.jpg",
                        price = 55,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                                        new Food
                    {
                        name = "Schweppes",
                        shortDesc = "0.330 мл",
                        longDesc = "mojito",
                        img = "/img/Schweppes Mojito.jpg",
                        price = 55,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },

                    new Food
                    {
                        name = "Dorna",
                        shortDesc = "0.500 мл",
                        longDesc = "газована",
                        img = "/img/Dorna.jpg",
                        price = 48,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                    new Food
                    {
                        name = "Dorna",
                        shortDesc = "0.500 мл",
                        longDesc = "не газована",
                        img = "/img/DornaNe.jpg",
                        price = 48,
                        isFavourite = false,
                        available = true,
                        Category = _categoryFood.AllCategories.First()
                    },
                                        new Food
                    {
                        name = "Galicia.jpg",
                        shortDesc = "1 л",
                        longDesc = "мультифруктовий",
                        img = "/img/Galicia.jpg",
                        price = 124,
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

