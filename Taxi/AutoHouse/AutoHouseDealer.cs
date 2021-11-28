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
        private readonly VehicleFleet vehicleFleet;

        public AutoHouseDealer(PassengerCarBuilder builder, VehicleFleet vehicleFleet)
        {
            this.vehicleFleet = vehicleFleet;
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
            Console.WriteLine(carForSale.MakeAndModel);
        }

        public void SellCar()
        {
            vehicleFleet.Add(carForSale);
        }
    }
}
