using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {   
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        [HttpGet]
        public IActionResult CheckoutForm()
        {
            return View();
        }
    }
}
