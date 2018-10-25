using AppServices.Interfaces;
using MyTestWebServer.Return;
using SimpleInjectorContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace MyTestWebServer
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        [WebMethod]        
        public List<OrderDTO> ListOrders()
        {
            BootStrapper.Init();
            using (var orderService = BootStrapper.Container.GetInstance<IOrderService>())
            {
                var listOrders = orderService.ListOrders();
                var ordersDTO = new List<OrderDTO>();
                foreach(var orderDomain in listOrders)
                {
                    ordersDTO.Add(new OrderDTO() { Id = orderDomain.Id, Name = orderDomain.Name });
                }

                return ordersDTO;
            }
        }

        [WebMethod]
        public OrderDTO GetOrder()
        {
            BootStrapper.Init();
            using (var orderService = BootStrapper.Container.GetInstance<IOrderService>())
            {
                var order = orderService.GetFirst();
                Thread.Sleep(10000);
                return new OrderDTO() { Id = order.Id, Name = order.Name };
            }
        }

        [WebMethod]
        public OrderDTO CreateOneOrder()
        {
            BootStrapper.Init();
            using (var orderService = BootStrapper.Container.GetInstance<IOrderService>())
            {
                var order = new OrderDTO() { Name = "Novo" };
                orderService.CreateNewOrder("Novo");
                return order;
            }
        }
    }
}
