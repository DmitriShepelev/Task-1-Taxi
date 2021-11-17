using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Company;

namespace Taxi.AutoHouse
{
    class CarDealer
    {
        //CarConstructor constructor;
        //public CarDealer(CarConstructor constructor)
        //{
        //    this.constructor = constructor;
        //}
        public void SellCar(CarConstructor constructor)
        {
            constructor.ChooseEngine();
            constructor.ChooseBody();
            constructor.ChooseEquipment();
            constructor.FuelConsumption();
            constructor.Cost();
            var completeCar = constructor.GetCar();
            var fleetInstance = VehicleFleet.Instance;
            fleetInstance.Add(completeCar);
            //VehicleFleet.Instance.Add(constructor.GetCar());
        }
    }
}
