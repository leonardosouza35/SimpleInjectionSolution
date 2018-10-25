using DomainClasses.Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> ListOrders();
        void CreateNewOrder(string Name);

    }
}
