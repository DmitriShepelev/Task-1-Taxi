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

        ICollection<Car> IVehicleFleet.Cars => carEntityList;

        public void Add(Car carEntity)
        {
            carEntityList.Add(carEntity);
        }

        public ICollection<Car> SortByConsumption()
        {
            return carEntityList.OrderBy(x => x.FuelConsumption).ToArray();
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
            return carEntityList.Where(car => car.TopSpeed >= startRange && car.TopSpeed <= endRange).ToArray();
        }
    }
}
