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

namespace Taxi.Interfaces
{
    interface IAutoHouse
    {
        Car ConstructCar(Engine engine, string makeAndModel, int topSpeed, float fuelConsumption, Body body, Equipment equipment, KindOfCars kindOfCars, decimal cost);
        void SellCar();
    }
}
