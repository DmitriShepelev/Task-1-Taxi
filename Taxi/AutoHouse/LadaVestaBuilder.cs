using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;

namespace Taxi.AutoHouse
{
    class LadaVestaBuilder : PassengerCarBuilder
    {
        readonly Car instance = new();
        public override void MakeAndModel(string makeAndModel) => instance.MakeAndModel = "Lada Vesta";

        public override void KindOfCars(KindOfCars kindOfCars) => instance.KindOfCars = new LightVehicle();

        public override void ChooseBody(Body body) => instance.Body = new Sedan();

        public override void ChooseEngine(Engine engine) => instance.Engine = new GasEngine();

        public override void ChooseEquipment(Equipment equipment) => instance.Equipment = new BasicEquipment();

        public override void Cost(decimal cost) => instance.Cost = 11000;
        public override void TopSpeed(int topSpeed) => instance.TopSpeed = 180;
        public override void FuelConsumption(float fuelConsumption) => instance.FuelConsumption = 8.5f;

        public override Car GetCar() => instance;
        public override string ToString()
        {
            return instance.ToString();
        }
    }
}
