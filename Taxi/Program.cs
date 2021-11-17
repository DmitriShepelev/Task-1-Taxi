using System;
using System.Collections.Generic;
using Taxi.AutoHouse;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;
using Taxi.Company;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            var bestsellers = new List<CarConstructor>()
            {
                new LadaVesta(),
                new VolkswagenPassat(),
                new MazdaCX7()
            };

            //var constructor = new ManualConstructor();
            //var ladaVesta = new LadaVesta();
            //var polo = new VolkswagenPassat();
            //var mazdaCX = new MazdaCX7();

            CarDealer dealer = new();
            foreach (var offer in bestsellers)
            {
                dealer.SellCar(offer);
            }

            var instance = VehicleFleet.Instance;
            instance.ShowFleetToConsole();

            var accountant = new AccoutingDepartment();
            Console.WriteLine($"\nTotal cost of the vehicle fleet = {accountant.TotalCostOfFleet()}$\n");

            var orderedFleet = instance.SortByConsumption();
            Console.Write("Sorting by fuel consumption = \t");
            foreach (var car in orderedFleet)
            {
                Console.Write($"{car.FuelConsumption} ");
            }
            Console.WriteLine();
        }
    }
}
