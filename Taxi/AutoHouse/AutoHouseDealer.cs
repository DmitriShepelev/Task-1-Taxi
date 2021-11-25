using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;
using Taxi.Company;

namespace Taxi.AutoHouse
{
    internal class AutoHouseDealer
    {
        private readonly PassengerCarBuilder _builder;
        private readonly Car carForSale;
        public AutoHouseDealer(PassengerCarBuilder builder)
        {
            _builder = builder;
            _builder.ChooseEngine();
            _builder.ChooseBody();
            _builder.ChooseEquipment();
            _builder.FuelConsumption();
            _builder.SetCost();
            _builder.SetTopSpeed();

            carForSale = _builder.GetCar();
        }
        public void ShowCar()
        {
            Console.WriteLine(carForSale);
        }

        public void SellCar()
        {
            // The VehicleFleet class implements the Singleton pattern.
            var fleetInstance = VehicleFleet.Instance;
            fleetInstance.Add(carForSale);
        }
    }
}
