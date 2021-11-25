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
        private decimal cost;
        private float fuelConsumption;
        private int topSpeed;

        internal decimal Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cost cannot be less than zero.");
                }
                else
                {
                    cost = value;
                }
            }
        }
        internal float FuelConsumption
        {
            get => fuelConsumption;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be equal to or less than zero.");
                }
                else
                {
                    fuelConsumption = value;
                }
            }
        }
        internal int TopSpeed
        {
            get => topSpeed;
            set
            {
                if (value <= 0 && value > 350)
                {
                    throw new ArgumentException("The maximum vehicle speed cannot be zero or exceed 350 km / h.");
                }
                else
                {
                    topSpeed = value;
                }
            }
        }

        internal KindOfCars KindOfCars { get; set; }
        internal string MakeAndModel { get; set; }
        internal Body Body { get;  set; }
        internal Engine Engine { get; set; }
        internal Equipment Equipment { get; set; }

        public override string ToString()
        {
            return $"{MakeAndModel}, {Body}, {Engine}, {Equipment}, Fuel Consumption = {FuelConsumption}, Cost = {Cost}, Top speed = {TopSpeed}";
        }
    }
}
