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
    class LadaVestaBuilder : PassengerCarBuilder
    {
        Car instance = new() { MakeAndModel = "Lada Vesta", KindOfCars = new LightVehicle(), };

        public override void ChooseBody() => instance.Body = new Sedan();

        public override void ChooseEngine() => instance.Engine = new GasEngine();

        public override void ChooseEquipment() => instance.Equipment = new BasicEquipment();

        public override void SetCost() => instance.Cost = 11000;
        public override void SetTopSpeed() => instance.TopSpeed = 180;
        public override void FuelConsumption() => instance.FuelConsumption = 8.5f;

        public override Car GetCar() => instance;
        public override string ToString()
        {
            return instance.ToString();
        }
    }
}
