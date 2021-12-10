using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class VehicleFactory
    {
        public Vehicle GetVehicle(string typeVehicle, string brand, string model, string options)
        {
            Vehicle result = null;

            if (typeVehicle == null)
            {
                result = null;
            }
            if (typeVehicle == "Car")
            {
                result = new Car(typeVehicle, brand, model, options);
            }
            else if (typeVehicle == "Truck")
            {
                result = new Truck(typeVehicle, brand, model, options);
            }
            else if (typeVehicle == "MotorCycle")
            {
                Console.WriteLine("Please select a color for your Vehicle!");
                string color = Console.ReadLine();

                result = new MotorCycle(typeVehicle, brand, model, options, color);
            }

            return result;
        }
    }
}
