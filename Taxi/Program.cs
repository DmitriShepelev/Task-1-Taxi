using System;
using System.Collections.Generic;
using Taxi.AutoHouse;
using Taxi.CarHierarchy;
using Taxi.CarHierarchy.Components.Body;
using Taxi.CarHierarchy.Components.Engine;
using Taxi.CarHierarchy.Components.Equipment;
using Taxi.CarHierarchy.Types;
using Taxi.Company;
using Taxi.Interfaces;
using Taxi.Menus;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFleet vehicleFleet = new VehicleFleet();
            Console.WriteLine("Welcome to the Taxi program!\n\nPlease select the first vehicle for your fleet:");

            var builder = new CarBuilder();
            var dealer = new AutoHouseDealer(builder, vehicleFleet);

            var bestOffers = new List<Car>
            {
                dealer.ConstructLadaVesta(),
                dealer.ConstructVolkswagenPassat(),
                dealer.ConstructMazdaCX7()
            };



            bool menu = true;
            while (menu)
            {
                menu = CarPurchaseMenu.AddCar(bestOffers, vehicleFleet);
            }

            Console.WriteLine("The following options are available to you. ");


            menu = true;
            while (menu)
            {
                menu = MainMenu.Menu(bestOffers, vehicleFleet);
            }

        }
    }
}
