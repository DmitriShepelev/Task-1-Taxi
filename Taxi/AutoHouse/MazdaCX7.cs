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
    class MazdaCX7 : CarConstructor
    {
        Car instance = new() { MakeAndModel = "Mazda CX-7", KindOfCars = new LightVehicle(), };

        public override void ChooseBody() => instance.Body = new Crossover();

        public override void ChooseEngine() => instance.Engine = new GasEngine();

        public override void ChooseEquipment() => instance.Equipment = new DeluxeEquipment();

        public override void Cost() => instance.Cost = 20000;

        public override void FuelConsumption() => instance.FuelConsumption = 15f;

        public override Car GetCar() => instance;
    }
}
