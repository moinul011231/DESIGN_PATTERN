using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Coding_Part_1.AbstractFactory
{
    public static class ClientCodeForAbstractFactory
    {
        public static void UseAbstractFactory()
        {
            //Regular Vehicle
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactrory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();

            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();

            //Sport Car
            IVehicleFactory sportVehicalFactory = new RegularVehicleFactrory();
            IBike SportBike = sportVehicalFactory.CreateBike();
            SportBike.GetDetails();

            ICar SportCar = sportVehicalFactory.CreateCar();
            SportCar.GetDetails();

        }
    }
}
