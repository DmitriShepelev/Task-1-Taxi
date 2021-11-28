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
    public class CarBuilder : Builder
    {
        readonly Car instance = new();
        public override void MakeAndModel(string makeAndModel) => instance.MakeAndModel = makeAndModel;

        public override void KindOfCars(KindOfCars kindOfCars) => instance.KindOfCars = kindOfCars;

        public override void ChooseBody(Body body) => instance.Body = body;

        public override void ChooseEngine(Engine engine) => instance.Engine = engine;

        public override void ChooseEquipment(Equipment equipment) => instance.Equipment = equipment;

        public override void Cost(decimal cost) => instance.Cost = cost;
        public override void TopSpeed(int topSpeed) => instance.TopSpeed = topSpeed;
        public override void FuelConsumption(float fuelConsumption) => instance.FuelConsumption = fuelConsumption;

        public override Car GetCar() => instance;
        public override string ToString() => instance.ToString();

    }
}
