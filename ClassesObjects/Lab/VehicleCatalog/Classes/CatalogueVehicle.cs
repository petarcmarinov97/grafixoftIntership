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
            //Car --> Audi: A3 - hors power 
            foreach(Vehicle vehicle in Vehicles)
            {
                string aditionalValue = vehicle.GetAditionalValue();
                Console.WriteLine($"{vehicle.Type}: {vehicle.Model} - {vehicle.Brand} - {aditionalValue}");
            }

            /*foreach(Truck truck in Vehicles)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }*/
        }
    }
    /* public void PrintVehicles(string typeVehicle)
     {
         if (typeVehicle == "Car")
         {
             Console.WriteLine($"Cars:");
             foreach (Vehicle vehicle in Vehicles)
             {
                 if (vehicle.GetType() == typeof(Car))
                 {
                     var car = (Car)vehicle;
                     Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                 }
             }
         }

         if (typeVehicle == "Truck")
         {
             Console.WriteLine($"Trucks:");
             foreach (Vehicle vehicle in Vehicles)
             {
                 if (vehicle.GetType() == typeof(Truck))
                 {
                     var truck = (Truck)vehicle;
                     Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                 }
             }
       */
}
//Two Methods for catalog one of them with parameter(type String) and the other parameterless Method
//Method Overloading !!!!!!!!
//If we pass a param -> Print only the Vehicles from the params example: cars-> print only the cars
//If is empty pass -> print all the vehicles includes cars and trucks
//User friendly error exepssions 
