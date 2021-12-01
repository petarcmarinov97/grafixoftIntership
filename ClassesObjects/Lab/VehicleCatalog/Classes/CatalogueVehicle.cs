using System;
using System.Linq;
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
        public List<Vehicle> GetVehiclesByCriteria(string criteria)
        {
            List<Vehicle> cars = Vehicles;
            List<Vehicle> newCars = cars;
            if (criteria == "accending")
            {
                newCars = cars.OrderBy(x => x.Brand).ToList();
            }
            else if (criteria == "descending")
            {
                newCars = cars.OrderByDescending(x => x.Brand).ToList();
            }

            return newCars;
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

        /*public void PrintVehicles(string typeVehicle, string brand)
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Type == typeVehicle && vehicle.Brand == brand)
                {
                    Console.WriteLine(vehicle.GetVehicleInfo());
                }
            }
        }*/
        // [x] Add new class motorcycle with two properties ( другото да е цвят или нш друго) 
        // [] Sort acc/dec alphabetical by the parameter example sort("accending"/"decending")
        // [x] Select function -> passing a type(car, truck ...) and search by Model Name. ---> Printing the vehicles.
        // [x] Remove function -> passing a type(car, truck ...) and search by Model Name. ---> Remove the vehicles from the list.

        // !!! Ако се нуждая от принтиране да се преизползват съществуващите функции за принтиране без да се добавят нови такива
        // (Ако се нуждаят от рефактуриране да се направят)
    }
}