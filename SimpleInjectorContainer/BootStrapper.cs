using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorContainer
{
    public class BootStrapper
    {
        public static Container Container;

        public static void Init()
        {
            Container = new Container();
            ServicesRegister.Register(Container);
        }
    }
}
