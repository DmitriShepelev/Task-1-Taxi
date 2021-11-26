using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.AutoHouse;

namespace Taxi.Menus
{
    class CarPurchaseMenu
    {
        internal static bool AddCar(List<PassengerCarBuilder> bestOffers)
        {
            int positionNumber = 1;
            foreach (var offer in bestOffers)
            {
                Console.Write($"{positionNumber}. ");
                AutoHouseDealer dealer = new AutoHouseDealer(offer);
                dealer.ShowCar();
                positionNumber++;
            }
            Console.WriteLine("4. Cancel.");

            Console.WriteLine("Enter the selected car number: ");
            int input;

            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input < 5)
            {
                switch (input)
                {
                    case 1:
                        new AutoHouseDealer(bestOffers[0]).SellCar();
                        Return();
                        return false;
                    case 2:
                        new AutoHouseDealer(bestOffers[1]).SellCar();
                        Return();
                        return false;
                    case 3:
                        new AutoHouseDealer(bestOffers[2]).SellCar();
                        Return();
                        return false;
                    case 4:
                        return false;
                }
                return false;
            }
            else
            {
                Console.WriteLine("\nInvalid input. try again\n");
                AddCar(bestOffers);
                return false;
            }

        }

        private static void Return()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nVehicle added successfully\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
