using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Cars;

namespace Taxi.Company
{
    public class VehicleFleet
    {
        static Lazy<VehicleFleet> instance = new Lazy<VehicleFleet>();
        private List<Car> carEntityList = new();
        public static VehicleFleet Instance { get => instance.Value; }
        public void Add(Car carEntity)
        {
            carEntityList.Add(carEntity);
        }
        public void Show()
        {
            foreach (var item in carEntityList)
            {
                Console.WriteLine($"{item.Body}, {item.FuelConsumption}, {item.Cost}");
            }
        }
    }
}
