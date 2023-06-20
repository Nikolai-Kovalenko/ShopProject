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
                        img = "/img/volga.jpg", 
                        price = 700, 
                        isFavourite = true, 
                        available = true, 
                        category = _categoryCars.AllCategoris.Last()
                    },

                    new Car {
                        name = "Tesla",
                        shortDesc = "Быстрый автомобить",
                        longDesc = "Красивый, быстрый и очень тихий",
                        img = "/img/teslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategoris.First()
                    },

                    new Car {
                        name = "Mercedes s class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Стильный внешний вид и шикарный солон",
                        img = "/img/mercedesSClass.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.AllCategoris.Last()
                    },

                    new Car {
                        name = "BMW",
                        shortDesc = "Чёрый как ночь",
                        longDesc = "Отличный автомобиль, почти такой же классный как Mercedes, только чёрный",
                        img = "/img/bmwBlack.jpg",
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
