using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace VehicleCatalog
{
    public class CatalogueVehicle
    {
        public List<Vehicle> Vehicles { get; set; }
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
        public void PrintVehicles(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetVehicleInfo());
            }
        }
        public List<Vehicle> GetByTypeAndBrand(string typeVehicle, string brand)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Type == typeVehicle && vehicle.Brand == brand)
                {
                    vehicles.Add(vehicle);
                }
            }

            return vehicles;
        }
        public List<Vehicle> GetVehiclesByCriteria(string criteria)
        {
            List<Vehicle> cars = new List<Vehicle>();
            if (criteria == "accending")
            {
                cars = Vehicles.OrderBy(x => x.Brand).ToList();
            }
            else if (criteria == "descending")
            {
                cars = Vehicles.OrderByDescending(x => x.Brand).ToList();
            }

            return cars;
        }
        public void RemoveVehicles(string typeVehicle, string brand, string model)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Type == typeVehicle && vehicle.Brand == brand && vehicle.Model == model)
                {
                    vehicles.Add(vehicle);
                }
            }

            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicles.Remove(vehicles[i]);
                Console.WriteLine("Has been deleted");
            }
        }
    }
}