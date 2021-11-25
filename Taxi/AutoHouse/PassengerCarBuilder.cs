using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Types;

namespace Taxi.AutoHouse
{
    public abstract class PassengerCarBuilder
    {
        public abstract void ChooseEngine();
        public abstract void ChooseBody();
        public abstract void ChooseEquipment();
        public abstract void SetTopSpeed();
        public abstract void FuelConsumption();
        public abstract void SetCost();
        public abstract Car GetCar();
    }
}
