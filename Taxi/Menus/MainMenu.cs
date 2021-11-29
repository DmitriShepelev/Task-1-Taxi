using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.AutoHouse;
using Taxi.CarHierarchy;
using Taxi.Company;
using Taxi.Interfaces;

namespace Taxi.Menus
{
    class MainMenu
    {
        internal static bool Menu(List<Car> bestOffers, IVehicleFleet vehicleFleet)
        {
            Console.WriteLine("1. Add a car to the fleet");
            Console.WriteLine("2. Display vehicle fleet to console");
            Console.WriteLine("3. Calculate the total cost of the vehicle fleet");
            Console.WriteLine("4. Sort cars by fuel consumption");
            Console.WriteLine("5. Find cars by speed range");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Make your  choice:");

            if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input < 7)
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        CarPurchaseMenu.AddCar(bestOffers, vehicleFleet);
                        return true;
                    case 2:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        vehicleFleet.ShowFleetToConsole();
                        Console.ResetColor();
                        DelayAndReturn();
                        return true;
                    case 3:
                        var accountant = new AccoutingDepartment(vehicleFleet);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\nTotal cost of the vehicle fleet = {accountant.GetTotalCostOfFleet()}$\n");
                        Console.ResetColor();
                        DelayAndReturn();
                        return true;
                    case 4:
                        var orderedFleet = vehicleFleet.SortByConsumption();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Sorting by fuel consumption = \t");
                        foreach (var car in orderedFleet)
                        {
                            Console.Write($"{car.FuelConsumption} ");
                        }
                        Console.WriteLine();
                        Console.ResetColor();
                        DelayAndReturn();
                        return true;
                    case 5:
                        ShowCarBySpeedRange(vehicleFleet);
                        DelayAndReturn();
                        return true;
                    case 6:
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input. Try again\n");
                Console.ResetColor();
                Menu(bestOffers, vehicleFleet);
                return true;
            }
        }
        private static void ShowCarBySpeedRange(IVehicleFleet vehicleFleet)
        {
            Console.WriteLine("Enter the start value of the range:");
            int startValue, endValue;
            if (int.TryParse(Console.ReadLine(), out startValue))
            {
                Console.WriteLine("Enter the end value of the range:");
                if (int.TryParse(Console.ReadLine(), out endValue))
                {
                    if (startValue <= endValue && startValue >= 0)
                    {
                        var resultList = vehicleFleet.FindCarBySpeedRange(startValue, endValue);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        int positionNumber = 1;
                        foreach (var car in resultList)
                        {
                            Console.Write($"{positionNumber}. ");
                            Console.WriteLine(car.MakeAndModel + "\t Top speed = " + car.TopSpeed);
                            positionNumber++;
                        }
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("\nStart value cannot be less than zero and start value cannot be greater than end value\nTry again!\n");
                        ShowCarBySpeedRange(vehicleFleet);

                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again");
                ShowCarBySpeedRange(vehicleFleet);
            }
        }

        private static void DelayAndReturn()
        {
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
