using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Part_3
{
    public class EmployeeAdapter : IAdapter
    {

        ThirdParty thirdParty = new ThirdParty();
        public void AdapMatrixData(string[,] employessArray)
        {




            string Name = null;
            string Salary = null;

            List<Employee> Employees = new List<Employee>();


            for (int i = 0; i < employessArray.GetLength(0); i++)
            {
                for (int j = 0; j < employessArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Name = employessArray[i, j];
                    }


                    else
                    {
                        Salary = employessArray[i, j];
                    }

                }

                Employees.Add(new Employee(Name!, Salary!));


            }

            thirdParty.ProcessSalary(Employees);





        }
    }
}