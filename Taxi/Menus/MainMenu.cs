using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.AutoHouse;
using Taxi.Company;

namespace Taxi.Menus
{
    class MainMenu
    {
        internal static bool Menu()
        {
            Console.WriteLine("The following options are available to you. ");
            Console.WriteLine("1. Add a car to the fleet");
            Console.WriteLine("2. Display vehicle fleet to console");
            Console.WriteLine("3. Calculate the total cost of the vehicle fleet");
            Console.WriteLine("4. Sort cars by fuel consumption");
            Console.WriteLine("5. Find cars by speed range");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Make a choice:");

            int input;

            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input < 7)
            {
                switch (input)
                {
                    case 1:
                        CarPurchaseMenu.AddCar();
                        return true;
                    case 2:
                        VehicleFleet.Instance.ShowFleetToConsole();
                        return true;
                    case 3:
                        var accountant = new AccoutingDepartment();
                        Console.WriteLine($"\nTotal cost of the vehicle fleet = {accountant.GetTotalCostOfFleet()}$\n");
                        return true;
                    case 4:
                        var orderedFleet = VehicleFleet.Instance.SortByConsumption();
                        Console.Write("Sorting by fuel consumption = \t");
                        foreach (var car in orderedFleet)
                        {
                            Console.Write($"{car.FuelConsumption} ");
                        }
                        Console.WriteLine();
                        return true;
                    case 5:
                        ShowCarBySpeedRange();
                        return true;
                    case 6:
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. try again");
                Menu();
                return false;
            }
        }
        private static void ShowCarBySpeedRange()
        {
            Console.WriteLine("Enter the start value of the range:");
            int startValue, endValue;
            if (int.TryParse(Console.ReadLine(), out startValue) &&
                int.TryParse(Console.ReadLine(), out endValue) &&
                startValue <= endValue &&
                startValue > 0)
            {
                var resultList = VehicleFleet.Instance.FindCarBySpeedRange(startValue, endValue);
                foreach (var car in resultList)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. try again");
                ShowCarBySpeedRange();
            }
        }
    }
}
