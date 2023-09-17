using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.AbstractFactory
{
    public class SportBike: IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sport Bike Details..");
        }
    }
}
