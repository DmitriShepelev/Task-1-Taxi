using System;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.Interfaces;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;

namespace Taxi.AutoHouse
{
    public class AutoHouseDealer
    {
        private Builder builder;
        private readonly IVehicleFleet vehicleFleet;

        public AutoHouseDealer(Builder builder, IVehicleFleet vehicleFleet)
        {
            this.vehicleFleet = vehicleFleet;
            this.builder = builder;
        }
        public Car ConstructCar(Engine engine, string makeAndModel, int topSpeed, float fuelConsumption, Body body, Equipment equipment, KindOfCars kindOfCars, decimal cost)
        {
            builder = new CarBuilder();
            builder.KindOfCars(kindOfCars);
            builder.MakeAndModel(makeAndModel);
            builder.ChooseBody(body);
            builder.ChooseEngine(engine);
            builder.ChooseEquipment(equipment);
            builder.Cost(cost);
            builder.FuelConsumption(fuelConsumption);
            builder.TopSpeed(topSpeed);
            return builder.GetCar();
        }

        public Car ConstructLadaVesta()
        {
            builder = new CarBuilder();
            builder.KindOfCars(new LightVehicle());
            builder.MakeAndModel("Lada Vesta");
            builder.ChooseBody(new Sedan());
            builder.ChooseEngine(new GasEngine());
            builder.ChooseEquipment(new BasicEquipment());
            builder.Cost(11000);
            builder.FuelConsumption(8.5f);
            builder.TopSpeed(180);
            return builder.GetCar();
        }
        public Car ConstructMazdaCX7()
        {
            builder = new CarBuilder();
            builder.KindOfCars(new LightVehicle());
            builder.MakeAndModel("Mazda CX-7");
            builder.ChooseBody(new Crossover());
            builder.ChooseEngine(new GasEngine());
            builder.ChooseEquipment(new DeluxeEquipment());
            builder.Cost(20000);
            builder.FuelConsumption(15f);
            builder.TopSpeed(200);
            return builder.GetCar();
        }
        public Car ConstructVolkswagenPassat()
        {
            builder = new CarBuilder();
            builder.KindOfCars(new LightVehicle());
            builder.MakeAndModel("Volkswagen Passat");
            builder.ChooseBody(new StationWagon());
            builder.ChooseEngine(new DiselEngine());
            builder.ChooseEquipment(new MediumEquipment());
            builder.Cost(15000);
            builder.FuelConsumption(6.5f);
            builder.TopSpeed(190);
            return builder.GetCar();
        }
        public void SellCarToFleet(Car car) => vehicleFleet.Add(car);
    }
}
