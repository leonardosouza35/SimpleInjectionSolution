using AppServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Entities;
using Repositories;

namespace AppServices.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateNewOrder(string name)
        {
            _orderRepository.CreateNewOrder(name);
        }

        public void Dispose()
        {
            
        }

        public Order GetFirst()
        {
            return _orderRepository.ListOrders().First();
        }

        public List<Order> ListOrders()
        {
            return _orderRepository.ListOrders();
        }
    }
}
