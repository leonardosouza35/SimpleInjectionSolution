using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetOrders2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderServiceAPI.WebService1SoapClient client = new OrderServiceAPI.WebService1SoapClient();

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Chamada " + i.ToString());
                var retorno = client.CreateOneOrder();
                Console.WriteLine(retorno != null ? "Retorno com sucesso" : "Erro");
            }


            Console.WriteLine("Terminou Aqui");
            Console.ReadKey();

        }
    }
}
