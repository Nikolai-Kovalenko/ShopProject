using Shop.Data.Models;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Shop.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
