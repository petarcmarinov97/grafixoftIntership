using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace VehicleCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalog = new CatalogueVehicle();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split('/');

                string typeOfVehicle = tokens[0];
                string brandeOfVehicle = tokens[1];
                string modelOfVehicle = tokens[2];
                int horsesOrWeight = int.Parse(tokens[3]);

                if (typeOfVehicle != "Car" && typeOfVehicle != "Truck")
                {
                    throw new ArgumentException("Invalid type input!\nPlease insert Car or Truck!");
                }
                if (typeOfVehicle == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brandeOfVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horsesOrWeight
                    });
                }
                else
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brandeOfVehicle,
                        Model = modelOfVehicle,
                        Weight = horsesOrWeight
                    });
                }

                input = Console.ReadLine();
            }

            PrintTheCatalog(catalog);
        }
        static void PrintTheCatalog(CatalogueVehicle catalog)
        {
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}-{truck.Model}-{truck.Weight}hp");
                }
            }
        }
    }
}
