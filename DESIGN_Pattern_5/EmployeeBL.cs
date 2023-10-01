using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_Pattern_5
{
    public class EmployeeBL
    {


        public IEmployeeDAL Employee;

        public EmployeeBL(IEmployeeDAL employee)
        {
            this.Employee = employee;
        }

        public List<Employee> GetAllEmployee()
        {
            return Employee.SelectAllEmployees();
        }





    }
}