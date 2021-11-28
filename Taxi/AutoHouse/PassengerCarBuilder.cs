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
    public abstract class PassengerCarBuilder
    {
        public abstract void MakeAndModel(string makeAndModel);
        public abstract void KindOfCars(KindOfCars kindOfCars);
        public abstract void ChooseEngine(Engine engine);
        public abstract void ChooseBody(Body body);
        public abstract void ChooseEquipment(Equipment equipment);
        public abstract void TopSpeed(int topSpeed);
        public abstract void FuelConsumption(float fuelConsumption);
        public abstract void Cost(decimal cost);
        public abstract Car GetCar();
    }
}
