using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;
using Taxi.Interfaces;

namespace Taxi.Company
{
    public class VehicleFleet : IVehicleFleet
    {
        private readonly List<Car> carEntityList = new();
        internal ICollection<Car> Cars => carEntityList;
        internal VehicleFleet GetFleet { get => this; }

        public void Add(Car carEntity)
        {
            carEntityList.Add(carEntity);
        }

        public ICollection<Car> SortByConsumption()
        {
            return carEntityList.OrderBy(x => x.FuelConsumption).ToList();
        }
        public void ShowFleetToConsole()
        {
            var lineNumber = 1;
            foreach (var item in carEntityList)
            {
                Console.WriteLine(lineNumber + " " + item + "\n");
                lineNumber++;
            }
        }

        public IEnumerable<Car> FindCarBySpeedRange(int startRange, int endRange)
        {
            return carEntityList.Where(car => car.TopSpeed >= startRange && car.TopSpeed <= endRange).ToList();
        }
    }
}
