﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategoris
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Машины будущего", desc = "Машины которые питаються энергией природы"},
                    new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
                };
            }
        }
    }
}
