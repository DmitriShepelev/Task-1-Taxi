using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Cars.Components.Body;
using Taxi.Cars.Components.Engine;
using Taxi.Cars.Components.Equipment;
using Taxi.Cars.Types;

namespace Taxi.Cars
{
    public class Car
    {
        public int Id { get; }
        public decimal Cost { get; set; }
        public float FuelConsumption { get; set; }

        public KindOfCars KindOfCars { get; internal set; }
        public string MakeAndModel { get; internal set; }
        public Body Body { get; internal set; }
        public Engine Engine { get; internal set; }
        public Equipment Equipment { get; internal set; }


        //public CarEntity(KindOfCars kindOfCars, decimal cost, int fuelConsumption)
        //{
        //    KindOfCars = kindOfCars;
        //    Cost = cost;
        //    FuelConsumption = fuelConsumption;
        //}
    }
}
