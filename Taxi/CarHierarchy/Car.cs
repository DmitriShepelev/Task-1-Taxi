using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;

namespace Taxi.CarHierarchy
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

        public override string ToString()
        {
            return $"Make And Model = {MakeAndModel}, {Body}, {Engine}, {Equipment}, Fuel Consumption = {FuelConsumption}, Cost = {Cost}$";
        }
        //public CarEntity(KindOfCars kindOfCars, decimal cost, int fuelConsumption)
        //{
        //    KindOfCars = kindOfCars;
        //    Cost = cost;
        //    FuelConsumption = fuelConsumption;
        //}
    }
}
