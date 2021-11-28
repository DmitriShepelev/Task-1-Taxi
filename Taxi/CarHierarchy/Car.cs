﻿using System;
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
        private Body body;
        private Engine engine;
        private Equipment equipment;
        private string makeAndModel;
        private decimal cost;
        private float fuelConsumption;
        private int topSpeed;
        private Body body1;

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
                if (value <= 0 || value > 350)
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
            get => kindOfCars;
            internal set => kindOfCars = value ?? throw new ArgumentNullException(nameof(KindOfCars));
        }

        public string MakeAndModel
        {
            get => makeAndModel;
            internal set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(MakeAndModel));
                }
                makeAndModel = value;
            }
        }

        public Body Body
        {
            get => body;
            internal set => body = value ?? throw new ArgumentNullException(nameof(Body));
        }
        public Engine Engine 
        { 
            get => engine; 
            internal set => engine = value ?? throw new ArgumentNullException(nameof(Engine)); 
        }
        public Equipment Equipment 
        { 
            get => equipment; 
            internal set => equipment = value ?? throw new ArgumentNullException(nameof(Equipment));
        }

        public override string ToString()
        {
            return $"{MakeAndModel}, {Body}, {Engine}, {Equipment}, Fuel Consumption = {FuelConsumption}, Cost = {Cost}, Top speed = {TopSpeed}";
        }
    }
}
