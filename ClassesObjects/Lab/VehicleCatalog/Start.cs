using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace VehicleCatalog
{
    internal class Start
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
                string options = tokens[3];

                VehicleFactory factory = new VehicleFactory();
                Vehicle vehicleToAdd = factory.GetVehicle(typeOfVehicle, brandeOfVehicle, modelOfVehicle, options);

                if (vehicleToAdd != null)
                {
                    catalog.Vehicles.Add(vehicleToAdd);
                }
                else
                {
                    throw new ArgumentNullException("Invalid input!");
                }

                input = Console.ReadLine();
            }
            ;
            //string typeVehicle = "Car";
            Console.WriteLine("______________________________");
            catalog.PrintVehicles();
        }
    }
}
