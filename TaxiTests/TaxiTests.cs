using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using Taxi.AutoHouse;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;
using Taxi.Company;

namespace Taxi.Tests
{
    [TestFixture]
    public class Tests
    {
        Builder builder;
        VehicleFleet fleet;
        AutoHouseDealer dealer;

        [SetUp]
        public void Initialize()
        {
            builder = new CarBuilder();
            fleet = new VehicleFleet();
            dealer = new AutoHouseDealer(builder, fleet);

        }


        [Test]
        public void CarClassIsCreated()
        {
            var car = dealer.ConstructLadaVesta();
            Assert.IsNotNull(car, "'Car' class is created.");
        }

        [Test]
        public void ConstructCarMethod_WithNullParameters_ThrowsArgumentNullException()
        {
            Assert.Multiple(() =>
                {
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(null, "Kia Rio", 220, 5f, new Sedan(), new DeluxeEquipment(), new LightVehicle(), 17000m));
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(new GasEngine(), null, 220, 5f, new Sedan(), new DeluxeEquipment(), new LightVehicle(), 17000m));
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(new GasEngine(), "Kia Rio", 220, 5f, null, new DeluxeEquipment(), new LightVehicle(), 17000m));
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(new GasEngine(), "Kia Rio", 220, 5f, new Sedan(), null, new LightVehicle(), 17000m));
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(new GasEngine(), "Kia Rio", 220, 5f, new Sedan(), new DeluxeEquipment(), null, 17000m));
                    Assert.Throws<ArgumentNullException>(() => dealer.ConstructCar(new GasEngine(), "", 220, 5f, new Sedan(), new DeluxeEquipment(), null, 17000m));

                });
        }
        [Test]
        public void BuilderMethods_WithNullParameters_ThrowsArgumentNullException()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentNullException>(() => builder.ChooseBody(null));
                Assert.Throws<ArgumentNullException>(() => builder.ChooseEngine(null));
                Assert.Throws<ArgumentNullException>(() => builder.ChooseEquipment(null));
                Assert.Throws<ArgumentNullException>(() => builder.KindOfCars(null));
                Assert.Throws<ArgumentNullException>(() => builder.MakeAndModel(""));
                Assert.Throws<ArgumentNullException>(() => builder.MakeAndModel(null));
            });
        }

        [Test]
        public void IncorrectValueOfFuelConsumption_ThrowsArgumentException()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentException>(() => builder.FuelConsumption(int.MinValue));
                Assert.Throws<ArgumentException>(() => builder.FuelConsumption(-1));
                Assert.Throws<ArgumentException>(() => builder.FuelConsumption(0));
            });
        }

        [Test]
        public void CostOfCarLessThanZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => builder.Cost(-1));
        }

        [Test]
        public void IncorrectValueOfTopSpeed_ThrowsArgumentException()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentException>(() => builder.TopSpeed(int.MinValue));
                Assert.Throws<ArgumentException>(() => builder.TopSpeed(-1));
                Assert.Throws<ArgumentException>(() => builder.TopSpeed(0));
                Assert.Throws<ArgumentException>(() => builder.TopSpeed(351));
                Assert.Throws<ArgumentException>(() => builder.TopSpeed(int.MaxValue));
            });
        }

    }
}