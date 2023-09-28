using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public class Employee
    {
        public Employee(string name, string salary)
        {

            Name = name;

            Salary = salary;
        }


        public string Name { get; set; }

        public string Salary { get; set; }


    }
}