using Microsoft.IdentityModel.Tokens;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;

namespace Shop.Data.Reository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.createOrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    carId = item.car.id,
                    orderId = order.id,
                    price = (uint)item.car.price
                };
                
                appDBContent.OrderDetail.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
