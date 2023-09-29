using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern_4
{
    public class ProxyFolder : IsharedFolder
    {
        private SharedFolder _sharedFolder;
        private Employee _employee;

        public ProxyFolder(Employee employee)
        {
            _employee = employee;
        }

        public void PerformOperation()
        {

            if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "Manager")
            {

                _sharedFolder = new SharedFolder();
                Console.WriteLine("Its calling sharefolder to RW operation");
                _sharedFolder.PerformOperation();

            }

            else
            {
                Console.WriteLine("You dont have permission");
            }


        }
    }
}