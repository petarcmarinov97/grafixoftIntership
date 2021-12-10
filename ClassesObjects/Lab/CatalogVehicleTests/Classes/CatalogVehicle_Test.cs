using NUnit.Framework;
using VehicleCatalog;
using System.Collections.Generic;
using Moq;
using System.Linq;
using System.Text;

namespace VehicleCatog.Tests
{
    internal class CatalogVehicleTest
    {
        public Car newCar1 = new Car("Car", "Mercedes", "CLK500", "250");
        public Car newCar2 = new Car("Car", "Audi", "A3", "90");
        public Car newCar3 = new Car("Car", "Opel", "Astra", "150");
        public Car newCar4 = new Car("Car", "BMW", "M5", "350");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_PrintVehicles()
        {
            CatalogueVehicle catalog = new CatalogueVehicle();

            try
            {
                catalog.PrintVehicles();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void Test_PrintVehiclesWithListParameter()
        {
            CatalogueVehicle catalog = new CatalogueVehicle();
            List<Vehicle> newVechicles = new List<Vehicle>{ newCar1, newCar2, newCar3, newCar4 };
            catalog.Vehicles = newVechicles;
            
            try
            {
                catalog.PrintVehicles(newVechicles);
                Assert.IsTrue (true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void Test_ShouldReturnEmptyListWhenCatalogIsEmpty()
        {
            //Arange
            CatalogueVehicle catalog = new CatalogueVehicle();
            catalog.Vehicles = new List<Vehicle>();

            //Act
            var result = catalog.GetVehiclesByCriteria("accending");
            List<Vehicle> newListAccending = new List<Vehicle>();

            //Assert
            CollectionAssert.AreEqual(newListAccending, result);
        }
        [Test]
        public void Test_ShouldReturnListAccendingOrder()
        {
            //Arange
            CatalogueVehicle catalog = new CatalogueVehicle();

            catalog.Vehicles = new List<Vehicle> { newCar1, newCar2, newCar3, newCar4 };
            List<Vehicle> newListAccending = new List<Vehicle> { newCar2, newCar4, newCar1, newCar3 };

            //Act
            var resultAccending = catalog.GetVehiclesByCriteria("accending");

            //Assert
            CollectionAssert.AreEqual(newListAccending, resultAccending);
        }

        [Test]
        public void Test_ShouldReturnListDescendingOrder()
        {
            //Arange
            CatalogueVehicle catalog = new CatalogueVehicle();
            catalog.Vehicles = new List<Vehicle> { newCar1, newCar2, newCar3, newCar4 };
            List<Vehicle> newListDescending = new List<Vehicle> { newCar3, newCar1, newCar4, newCar2 };

            //Act
            var resultDescending = catalog.GetVehiclesByCriteria("descending");

            //Assert
            CollectionAssert.AreEqual(newListDescending, resultDescending);
        }

        [Test]
        public void Test_ShouldReturnListWithTrueTypeAndBrand()
        {
            //Arange
            newCar4 = new Car("Car", "Audi", "A5", "150");

            Truck newTruck1 = new Truck("Truck", "Mercedes", "AH500", "9500");

            CatalogueVehicle catalog = new CatalogueVehicle();

            catalog.Vehicles = new List<Vehicle> { newCar1, newCar2, newCar3, newCar4, newTruck1 };
            List<Vehicle> newList = new List<Vehicle> { newCar2, newCar4 };

            //Act
            var resultVehicles = catalog.GetByTypeAndBrand("Car", "Audi");

            //Assert
            CollectionAssert.AreEqual(newList, resultVehicles);
        }

        [Test]
        public void Test_ShouldReturnEmtyList_When_DoNotContainsAnyVehicle_GetByTypeAndBrand()
        {
            //Arange
            CatalogueVehicle catalog = new CatalogueVehicle();
            catalog.Vehicles = new List<Vehicle>();
            List<Vehicle> newList = new List<Vehicle>();

            //Act
            var resultVehicles = catalog.GetByTypeAndBrand("Car", "Audi");

            //Assert
            CollectionAssert.AreEqual(newList, resultVehicles);
        }
    }
}

