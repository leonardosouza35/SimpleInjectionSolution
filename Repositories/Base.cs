using DomainClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class Base
    {
        public static List<Order> orders = new List<Order>();

        public static List<Order> Orders
        {
            get
            {
                if (orders.Count == 0)
                {
                    orders = new List<Order>();
                    for (var i = 0; i <= 1000; i++)
                    {
                        orders.Add(new Order() { Id = i, Name = "Name" + i.ToString() });
                    }
                    
                }

                return orders;
            }
        }
    }
}
