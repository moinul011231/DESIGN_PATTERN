using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> list = new List<Employee>
           {
               new Employee() {Id=1,Name="Adil",Department="PROJECT MANAGEMENT"},
               new Employee() {Id=2,Name="SAJIB",Department="MANAGEMENT"},
               new Employee() {Id=3,Name="SUNNY",Department="CEO"}


           };

            return list;
        }
    }
}