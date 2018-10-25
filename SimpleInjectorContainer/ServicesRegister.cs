using AppServices.Interfaces;
using AppServices.Services;
using Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorContainer
{
    public class ServicesRegister
    {
        public static void Register(Container container)
        {
            container.Register<IOrderService, OrderService>(Lifestyle.Transient);
            container.Register<IOrderRepository, OrderRepository>(Lifestyle.Transient);
        }
    }
}
