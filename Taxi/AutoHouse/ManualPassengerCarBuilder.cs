using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;

namespace Taxi.AutoHouse
{
    class ManualPassengerCarBuilder : PassengerCarBuilder
    {
        Car instance = new Car();
        public override void ChooseBody()
        {
            Console.WriteLine("Выберите кузов:\n1 - Crossover\n2 - Sedan\n3 - Station Wagon");
            switch (Console.ReadLine())
            {
                case "1":
                    instance.Body = new Crossover();
                    break;
                case "2":
                    instance.Body = new Sedan();
                    break;
                case "3":
                    instance.Body = new StationWagon();
                    break;
                default:
                    break;
            }
        }

        public override void ChooseEngine()
        {
            //throw new NotImplementedException();
        }

        public override void ChooseEquipment()
        {
            //throw new NotImplementedException();
        }
        public override void FuelConsumption()
        {
            Console.WriteLine("Укажите средний расход топлива");
            float fuelConsumption;
            fuelConsumption = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
            instance.FuelConsumption = fuelConsumption;
        }
        public override void SetCost()
        {
            Console.WriteLine("Укажите цену");
            decimal cost;
            cost = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
            instance.Cost = cost;

        }

        public override Car GetCar()
        {
            return instance;
        }

        public override void SetTopSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
