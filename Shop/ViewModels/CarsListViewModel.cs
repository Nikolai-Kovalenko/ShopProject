﻿using Microsoft.AspNetCore.SignalR;
using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
