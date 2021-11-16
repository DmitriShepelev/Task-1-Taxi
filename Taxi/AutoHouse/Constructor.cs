using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Cars;

namespace Taxi.AutoHouse
{
    public abstract class Constructor
    {
        public abstract void ChooseEngine();
        public abstract void ChooseBody();
        public abstract void ChooseEquipment();
        public abstract void FuelConsumption();
        public abstract void Cost();
        public abstract Car GetCar();
    }
}
