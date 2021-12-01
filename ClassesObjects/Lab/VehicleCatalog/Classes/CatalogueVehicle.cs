using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace VehicleCatalog
{
    internal class CatalogueVehicle
    {
        public List<Vehicle> Vehicles { get; }
        public CatalogueVehicle()
        {
            Vehicles = new List<Vehicle>();
        }

        public void PrintVehicles()
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle.GetVehicleInfo());
            }
        }

        public void PrintVehicles(string typeVehicle)
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Type == typeVehicle)
                {
                    Console.WriteLine(vehicle.GetVehicleInfo());
                }
            }
        }
    }
}