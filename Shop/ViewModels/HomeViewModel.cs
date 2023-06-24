using Newtonsoft.Json.Linq;
using Shop.Data.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCar { get; set; }    
    }
}
