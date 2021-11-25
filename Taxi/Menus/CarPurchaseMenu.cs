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
        internal static bool AddCar()
        {
            var bestsellers = new List<PassengerCarBuilder>()
            {
                new LadaVestaBuilder(),
                new VolkswagenPassatBuilder(),
                new MazdaCX7Builder()
            };

            int positionNumber = 1;
            foreach (var offer in bestsellers)
            {
                Console.Write($"{positionNumber}. ");
                AutoHouseDealer dealer = new AutoHouseDealer(offer);
                dealer.ShowCar();
                positionNumber++;
            }
            Console.WriteLine("4 - Cancel.");

            int input;

            if (int.TryParse(Console.ReadLine(), out input) && input > 0 && input < 5)
            {
                switch (input)
                {
                    case 1:
                        new AutoHouseDealer(bestsellers[0]).SellCar();
                        Console.WriteLine("Vehicle added successfully");
                        return false;
                    case 2:
                        new AutoHouseDealer(bestsellers[1]).SellCar();
                        Console.WriteLine("Vehicle added successfully");
                        return false;
                    case 3:
                        new AutoHouseDealer(bestsellers[2]).SellCar();
                        Console.WriteLine("Vehicle added successfully");
                        return false;
                    case 4:
                        return false;
                }
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. try again");
                AddCar();
                return false;
            }

        }
    }
}
