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
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IsValidBrand()
        {
            Car SutCar = new Car("Car", "Audi", "A3", "90");

            Assert.AreEqual(SutCar.IsValidBrand("Audi"), true);
            Assert.AreEqual(SutCar.IsValidBrand("Audi3"), false);

        }

        [Test]
        public void Test_IsValidModel()
        {
            Car SutCar = new Car("Car", "Audi", "A3", "90");

            Assert.AreEqual(SutCar.IsValidModel("A3"), true);
            Assert.AreEqual(SutCar.IsValidModel("A3."), false);
        }
    }
}
