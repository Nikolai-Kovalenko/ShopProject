using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using System.Net.WebSockets;
using Shop.ViewModels;
using System.Collections;
using System.Collections.Generic;
using Shop.Data.Models;
using System.Linq;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iAllCat)
        {
            _allCars = iAllCars;
            _allCategories = iAllCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category) 
        {
            string _category = category;
            string currCaregoty = "";

            IEnumerable<Car> cars = null;

            if(string.IsNullOrEmpty(category)) 
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.categoryId == 1).OrderBy(i => i.id);

                    currCaregoty = "Электромобили";
                } 
                else if (string.Equals("future", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.categoryId == 2).OrderBy(i => i.id);

                    currCaregoty = "Машины будущего";
                }
                else if (string.Equals("fuel", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.categoryId == 3).OrderBy(i => i.id);
                    
                    currCaregoty = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCaregoty

            };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}
