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
    class MazdaCX7Builder : PassengerCarBuilder
    {
        readonly Car instance = new();
        public override void MakeAndModel(string makeAndModel) => instance.MakeAndModel = "Mazda CX-7";

        public override void KindOfCars(KindOfCars kindOfCars) => instance.KindOfCars = new LightVehicle();

        public override void ChooseBody(Body body) => instance.Body = new Crossover();

        public override void ChooseEngine(Engine engine) => instance.Engine = new GasEngine();

        public override void ChooseEquipment(Equipment equipment) => instance.Equipment = new DeluxeEquipment();

        public override void Cost(decimal cost) => instance.Cost = 20000;
        public override void TopSpeed(int topSpeed) => instance.TopSpeed = 200;
        public override void FuelConsumption(float fuelConsumption) => instance.FuelConsumption = 15f;       

        public override Car GetCar() => instance;
        public override string ToString()
        {
            return instance.ToString();
        }
    }
}
