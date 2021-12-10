using NUnit.Framework;
using VehicleCatalog;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace VehicleCatog.Tests
{
    [TestFixture]
    public class CarTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IsValidCarInfo()
        {
            Car sut = new Car("Car", "Audi", "A3", "90");
            string expectedResult = "Car" + " ---> " + "Audi" + " - " + "A3" + " - " + "90" + "hp";
            Assert.AreEqual(sut.ToString(), expectedResult);
        }
    }
}