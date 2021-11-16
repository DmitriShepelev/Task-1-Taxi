using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Cars;
using Taxi.Cars.Components.Body;
using Taxi.Cars.Components.Engine;
using Taxi.Cars.Components.Equipment;
using Taxi.Cars.Types;

namespace Taxi.AutoHouse
{
    class LadaVesta : Constructor
    {
        Car instance = new() { MakeAndModel = "Lada Vesta", KindOfCars = new LightVehicle(),};

        public override void ChooseBody() => instance.Body = new Sedan();

        public override void ChooseEngine() => instance.Engine = new GasEngine();

        public override void ChooseEquipment() => instance.Equipment = new BasicEquipment();

        public override void Cost() => instance.Cost = 11000;

        public override void FuelConsumption() => instance.FuelConsumption = 6.5f;

        public override Car GetCar() => instance;
    }
}
