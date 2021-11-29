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
    class CarPurchaseMenu
    {
        internal static bool AddCar(List<Car> bestOffers, IVehicleFleet vehicleFleet)
        {
            int positionNumber = 1;
            foreach (var offer in bestOffers)
            {
                Console.Write($"{positionNumber}. "); 
                Console.WriteLine(offer.MakeAndModel);
                positionNumber++;
            }
            Console.WriteLine("4. Cancel.");

            Console.WriteLine("Enter the selected car number: ");
            int input;

            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input < 5)
            {
                var dealer = new AutoHouseDealer(new CarBuilder(), vehicleFleet);
                switch (input)
                {
                    case 1:
                        dealer.SellCarToFleet(bestOffers[0]);
                        Return();
                        return false;
                    case 2:
                        dealer.SellCarToFleet(bestOffers[1]);
                        Return();
                        return false;
                    case 3:
                        dealer.SellCarToFleet(bestOffers[2]);
                        Return();
                        return false;
                    case 4:
                        return false;
                }
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input. Try again\n");
                Console.ResetColor();
                AddCar(bestOffers, vehicleFleet);
                return true;
            }

        }

        private static void Return()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nVehicle added successfully\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
