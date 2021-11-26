using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Types;

namespace Taxi.Tests
{
    [TestFixture]
    public class Tests
    {
        private const string CarClassName = "Car";
        private Type _carType;
        private Car car = new Car();

        [SetUp]
        public void Initialize()
        {
            var assembly = Assembly.Load("Taxi");
            _carType = assembly.GetTypes().FirstOrDefault(
                t => t.Name.Equals(CarClassName, StringComparison.OrdinalIgnoreCase));
        }


        [Test]
        public void CarClassIsCreated()
        {
            Assert.IsNotNull(_carType, "'Car' class is not created.");
        }
    }
}