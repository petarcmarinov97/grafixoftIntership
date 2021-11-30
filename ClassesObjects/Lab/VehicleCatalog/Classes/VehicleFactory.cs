using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class VehicleFactory
    {
        public Vehicle GetVehicle(string typeVehicle, string brand, string model, string options)
        {
            if(typeVehicle == null)
            {
                return null;
            }
            if (typeVehicle == "Car")
            {
                Car newCar = new Car(typeVehicle, brand, model, options);
                return newCar;
            }
            else if(typeVehicle == "Truck")
            {
                return new Truck(typeVehicle, brand, model, options);
            }

            return null;
        }
    }
}
