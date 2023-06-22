using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }


            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Волга",
                        shortDesc = "Лучшая в своём роде",
                        longDesc = "Есть возможность разложить заднее сиденье чтобы поспать",
                        img = "/img/volga.jpg",
                        price = 700,
                        isFavourite = true,
                        available = true,
                        category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Быстрый автомобить",
                        longDesc = "Красивый, быстрый и очень тихий",
                        img = "/img/teslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Электромобили"]
                    },

                    new Car
                    {
                        name = "Mercedes s class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Стильный внешний вид и шикарный солон",
                        img = "/img/mercedesSClass.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        name = "BMW",
                        shortDesc = "Чёрый как ночь",
                        longDesc = "Отличный автомобиль, почти такой же классный как Mercedes, только чёрный",
                        img = "/img/bmwFullBlack.jpg",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        name = "Mercedes-Benz Smart",
                        shortDesc = "Уютный маленький пробник",
                        longDesc = "Можно поднять в руках к себе домой, чтобы не платить за стоянку",
                        img = "/img/mercedesSmartCar.jpg",
                        price = 12500,
                        isFavourite = true,
                        available = true,
                        category = Categories["Классические автомобили"]
                    },

                    new Car
                    {
                        name = "Future Cars",
                        shortDesc = "Машина будущего",
                        longDesc = "Здесь могла бы быть машина, которая может летать, но эта тоже ничего",
                        img = "/img/futureCars.jpg",
                        price = 999999,
                        isFavourite = true,
                        available = true,
                        category = Categories["Машины будущего"]
                    }
                );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {categoryName = "Машины будущего", desc = "Машины которые питаються энергией природы"},
                        new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (var el in list) 
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
