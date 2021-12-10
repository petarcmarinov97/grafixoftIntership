using NUnit.Framework;
using VehicleCatalog;
using System.Collections.Generic;
using Moq;
using System.Linq;
using System.Text;
using System;

namespace VehicleCatog.Tests
{
    internal class Vehicle_Test
    {
        public Car sutCar = new Car("Car", "Audi", "A3", "90");
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IsValidBrand()
        {
            Assert.AreEqual(sutCar.IsValidBrand("Audi"), true);
            Assert.AreEqual(sutCar.IsValidBrand("Audi3"), false);
        }

        [Test]
        public void Test_IsValidModel()
        {
            Assert.AreEqual(sutCar.IsValidModel("A3"), true);
            Assert.AreEqual(sutCar.IsValidModel("A3."), false);
        }
    }
}
