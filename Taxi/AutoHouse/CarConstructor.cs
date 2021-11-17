using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;

namespace Taxi.AutoHouse
{
    public abstract class CarConstructor
    {
        public abstract void ChooseEngine();
        public abstract void ChooseBody();
        public abstract void ChooseEquipment();
        public abstract void FuelConsumption();
        public abstract void Cost();
        public abstract Car GetCar();
    }
}
