using NUnit.Framework;
using VehicleCatalog;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace VehicleCatog.Tests
{
    internal class MotorCycle_Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_IsValidCycleInfo()
        {
            MotorCycle Sut = new MotorCycle("MotorCycle", "Suzuki", "Z150", "130", "red");
            string expectedResult = "MotorCycle" + " ---> " + "Suzuki" + " - " + "Z150" + " - " + "130" + "hp" + " | Color: " + "red";
            Assert.AreEqual(Sut.GetVehicleInfo(), expectedResult);
        }
    }
}
