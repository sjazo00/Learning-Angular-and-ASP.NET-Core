using Learning_Angular_and_ASP.NET_Core.Data.Entities;
using System.Collections.Generic;

namespace Learning_Angular_and_ASP.NET_Core.Data
{
    public interface IAppRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string username, int id);
        void AddEntity(object model);
        bool SaveAll();
    }
}