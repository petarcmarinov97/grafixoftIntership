using NUnit.Framework;
using VehicleCatalog;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace VehicleCatog.Tests
{
    public class Truck_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IsValidTruckInfo()
        {
            Truck sut = new Truck("Truck", "Audi", "A3", "5000");
            string expectedResult = "Truck" + " ---> " + "Audi" + " - " + "A3" + " - " + "5000" + "kg";
            Assert.AreEqual(sut.ToString(), expectedResult);
        }
    }
}
