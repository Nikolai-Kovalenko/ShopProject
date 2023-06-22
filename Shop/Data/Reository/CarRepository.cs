using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Shop.Data.Reository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
