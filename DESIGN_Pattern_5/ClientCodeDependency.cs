using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public static class ClientCodeDependency
    {



        public static void UseInjection()
        {

            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());

            List<Employee> employees = employeeBL.GetAllEmployee();



            foreach (Employee employee in employees)
            {


                Console.WriteLine($"Name: {employee.Name} ID: {employee.Id} Departmant: {employee.Department}");

            }

        }


    }
}