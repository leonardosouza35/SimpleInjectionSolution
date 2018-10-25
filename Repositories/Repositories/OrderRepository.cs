using DomainClasses.Entities;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void CreateNewOrder(string name)
        {
            Base.Orders.Add(new Order() { Id = 1, Name = name });
        }

        public List<Order> ListOrders()
        {
            return Base.Orders;
        }
    }
}
