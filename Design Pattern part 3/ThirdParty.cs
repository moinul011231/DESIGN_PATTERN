using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public class ThirdParty
    {

        public void ProcessSalary(List<Employee> employees)
        {

            foreach (var employee in employees)
            {

                Console.WriteLine(employee.Name, employee.Salary);

            }




        }

    }
}