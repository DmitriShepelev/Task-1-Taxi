using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;

namespace Taxi.AutoHouse
{
    class VolkswagenPassatBuilder : PassengerCarBuilder
    {
        Car instance = new() { MakeAndModel = "Volkswagen Passat", KindOfCars = new LightVehicle(), };

        public override void ChooseBody() => instance.Body = new StationWagon();

        public override void ChooseEngine() => instance.Engine = new DiselEngine();

        public override void ChooseEquipment() => instance.Equipment = new MediumEquipment();

        public override void SetCost() => instance.Cost = 15000;

        public override void SetTopSpeed() => instance.TopSpeed = 190;

        public override void FuelConsumption() => instance.FuelConsumption = 6.5f;

        public override Car GetCar() => instance;

    }
}
