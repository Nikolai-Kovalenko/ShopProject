using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
      private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Волга", 
                        shortDesc = "Лучшая в своём роде", 
                        longDesc = "Есть возможность разложить заднее сиденье чтобы поспать", 
                        img = "https://cdn.pixabay.com/photo/2020/02/17/10/42/volga-4856133_960_720.png", 
                        price = 700, 
                        isFavourite = true, 
                        available = true, 
                        category = _categoryCars.AllCategoris.Last()
                    },

                    new Car {
                        name = "Tesla",
                        shortDesc = "Быстрый автомобить",
                        longDesc = "Красивый, быстрый и очень тихий",
                        img = "https://w7.pngwing.com/pngs/347/928/png-transparent-tesla-model-x-tesla-model-s-tesla-motors-tesla-model-3-tesla-compact-car-sedan-headlamp.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategoris.First()
                    },

                    new Car {
                        name = "Mercedes s class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Стильный внешний вид и шикарный солон",
                        img = "https://www.seekpng.com/png/full/134-1346353_3-luggage-mercedes-benz-s-class-png.png",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategoris.Last()
                    },

                    new Car {
                        name = "BMW",
                        shortDesc = "Чёрый как ночь",
                        longDesc = "Отличный автомобиль, почти такой же классный как Mercedes, только чёрный",
                        img = "https://w7.pngwing.com/pngs/630/655/png-transparent-2018-bmw-x5-sport-utility-vehicle-car-audi-indicative-compact-car-car-vehicle.png",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategoris.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set   ; }

        public Car getObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}   
