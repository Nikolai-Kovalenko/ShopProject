using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Reository;
using Shop.ViewModels;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {   
        public IAllCars _carRep;
        public readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        } 

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel {shopCart = _shopCart};

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id) 
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
