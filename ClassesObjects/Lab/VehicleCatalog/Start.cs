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
            Console.WriteLine(catalog.ToString());
            Console.WriteLine("______________________________");
            Console.WriteLine("To search a vehicle by type and model type 1 !");
            Console.WriteLine("______________________________");
            Console.WriteLine("To Remove a vehicle type 2 !");
            Console.WriteLine("______________________________");
            Console.WriteLine("To Sort Vehicles by a criteria type 3 !");
            Console.WriteLine("______________________________");

            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Please enter data correctly in this line:\n  Type/Brand");
                string[] searchData = Console.ReadLine().Split('/');
                string type = searchData[0];
                string brand = searchData[1];

                Console.WriteLine("\nSecond Example:");

                catalog.PrintVehicles(catalog.GetByTypeAndBrand(type, brand));
            }
            else if (answer == 2)
            {
                Console.WriteLine("Please enter data correctly in this line:\n  Type/Brand/Model");
                string[] removeData = Console.ReadLine().Split('/');
                string type = removeData[0];
                string brand = removeData[1];
                string model = removeData[2];

                catalog.RemoveVehicles(type, brand, model);
                Console.WriteLine(catalog.ToString());
            }
            else if (answer == 3)
            {
                Console.WriteLine("Please enter the criteria which you want to be used:\n   accending or descending");
                string criteria = Console.ReadLine();

                catalog.PrintVehicles(catalog.GetVehiclesByCriteria(criteria));
            }
        }
    }
}
