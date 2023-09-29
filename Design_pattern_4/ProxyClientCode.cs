using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public static class ProxyClientCode
    {


        public static void UserProxy()
        {

            Employee ep1 = new Employee("Sajib", "CEO");
            ProxyFolder proxy = new ProxyFolder(ep1);
            proxy.PerformOperation();

            Console.WriteLine();


            Employee ep2 = new Employee("Sani", "Admin");
            ProxyFolder proxy1 = new ProxyFolder(ep2);
            proxy1.PerformOperation();



        }

    }
}