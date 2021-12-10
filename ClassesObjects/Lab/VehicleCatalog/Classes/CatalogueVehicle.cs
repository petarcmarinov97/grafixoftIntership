using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace VehicleCatalog
{
    public class CatalogueVehicle
    {
        public CatalogueVehicle()
        {
            Vehicles = new List<Vehicle>();
        }
        public List<Vehicle> Vehicles { get; set; }
        public void PrintVehicles()
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        } // is equal to catalog.ToString()

        public void PrintVehicles(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
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
            List<Vehicle> vehicles = new List<Vehicle>();
            if (criteria == "accending")
            {
                vehicles = Vehicles.OrderBy(x => x.Brand).ToList();
            }
            else if (criteria == "descending")
            {
                vehicles = Vehicles.OrderByDescending(x => x.Brand).ToList();
            }

            return vehicles;
        }

        public void RemoveVehicles(string typeVehicle, string brand, string model)
        {
            this.Vehicles.RemoveAll(vehicle => vehicle.Type == typeVehicle && vehicle.Brand == brand && vehicle.Model == model);

            /*foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Type == typeVehicle && vehicle.Brand == brand && vehicle.Model == model)
                {
                    vehicles.Add(vehicle);
                }
            }*/

            /*for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicles.Remove(vehicles[i]);
                Console.WriteLine("Has been deleted");
            }*/
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Vehicles.ForEach(vehicle => result.AppendLine(vehicle.ToString()));
            return result.ToString();
        }
    }
}