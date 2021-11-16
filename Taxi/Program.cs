using System;
using Taxi.AutoHouse;
using Taxi.Cars;
using Taxi.Cars.Components.Body;
using Taxi.Cars.Components.Engine;
using Taxi.Cars.Components.Equipment;
using Taxi.Cars.Types;
using Taxi.Company;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var entity = new CarEntity(new LightVehicle(), 12000, 8)
            //{
            //    Body = new Sedan(),
            //    Equipment = new StandartEquipment(),
            //    Engine = new GasEngine()
            //};
            var constructor = new LightVehicleConstructor();
            var dealer = new CarDealer(constructor);
            dealer.SellCar();
            var instance = VehicleFleet.Instance;
            instance.Show();
        }
    }
}
