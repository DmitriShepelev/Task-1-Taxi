using System;
using System.Collections.Generic;
using Taxi.AutoHouse;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;
using Taxi.Company;
using Taxi.Menus;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Taxi program!\nPlease select the first vehicle for your fleet:");
            bool menu = true;
            while (menu)
            {
                menu = CarPurchaseMenu.AddCar();
            }

            menu = true;
            while (menu)
            {
                menu = MainMenu.Menu();
            }

            //var bestsellers = new List<PassengerCarBuilder>()
            //{
            //    new LadaVestaBuilder(),
            //    new VolkswagenPassatBuilder(),
            //    new MazdaCX7Builder()
            //};

            //var constructor = new ManualConstructor();

            //AutoHouseDealer dealer = new();

            //foreach (var offer in bestsellers)
            //{
            //    AutoHouseDealer dealer = new AutoHouseDealer(offer);
            //    dealer.ShowCar();
            //}

            //foreach (var offer in bestsellers)
            //{
            //    AutoHouseDealer dealer = new AutoHouseDealer(offer);
            //    dealer.SellCar();
            //}

            //var instance = VehicleFleet.Instance;
            ////instance.ShowFleetToConsole();

            //var accountant = new AccoutingDepartment();
            //Console.WriteLine($"\nTotal cost of the vehicle fleet = {accountant.GetTotalCostOfFleet()}$\n");

            //var orderedFleet = instance.SortByConsumption();
            //Console.Write("Sorting by fuel consumption = \t");
            //foreach (var car in orderedFleet)
            //{
            //    Console.Write($"{car.FuelConsumption} ");
            //}
            //Console.WriteLine();


        }
    }
}
