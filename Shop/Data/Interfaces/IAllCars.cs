using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars {  get; set; }
        Car getObjectCar(int carId);
    }
}
