using DomainClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.Interfaces
{
    public interface IOrderService : IDisposable
    {
        List<Order> ListOrders();
        Order GetFirst();
        void CreateNewOrder(string name);
    }
}
