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
        readonly Car instance = new();
        public override void MakeAndModel(string makeAndModel) => instance.MakeAndModel = "Volkswagen Passat";

        public override void KindOfCars(KindOfCars kindOfCars) => instance.KindOfCars = new LightVehicle();

        public override void ChooseBody(Body body) => instance.Body = new StationWagon();

        public override void ChooseEngine(Engine engine) => instance.Engine = new DiselEngine();

        public override void ChooseEquipment(Equipment equipment) => instance.Equipment = new MediumEquipment();

        public override void Cost(decimal cost) => instance.Cost = 15000;
        public override void TopSpeed(int topSpeed) => instance.TopSpeed = 190;
        public override void FuelConsumption(float fuelConsumption) => instance.FuelConsumption = 6.5f;

        public override Car GetCar() => instance;
        public override string ToString()
        {
            return instance.ToString();
        }
    }
}
