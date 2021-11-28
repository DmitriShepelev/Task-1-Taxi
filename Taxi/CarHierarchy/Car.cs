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
        private KindOfCars kindOfCars;
        private decimal cost;
        private float fuelConsumption;
        private int topSpeed;

        public decimal Cost
        {
            get => cost;
            internal set
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
        public float FuelConsumption
        {
            get => fuelConsumption;
            internal set
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
        public int TopSpeed
        {
            get => topSpeed;
            internal set
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

        public KindOfCars KindOfCars
        {
            get
            {
                if (kindOfCars == null)
                {
                    throw new ArgumentNullException("KindOfCars is null.");
                }
                return kindOfCars;
            }
            internal set
            {
                kindOfCars = value;
            }
        }

        public string MakeAndModel { get; internal set; }
        public Body Body { get; internal set; }
        public Engine Engine { get; internal set; }
        public Equipment Equipment { get; internal set; }

        public override string ToString()
        {
            return $"{MakeAndModel}, {Body}, {Engine}, {Equipment}, Fuel Consumption = {FuelConsumption}, Cost = {Cost}, Top speed = {TopSpeed}";
        }
    }
}
