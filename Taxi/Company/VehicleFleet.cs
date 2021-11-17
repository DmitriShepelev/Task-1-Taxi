using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;

namespace Taxi.Company
{
    public class VehicleFleet
    {
        static Lazy<VehicleFleet> instance = new Lazy<VehicleFleet>();
        private List<Car> carEntityList = new();
        public static VehicleFleet Instance { get => instance.Value; }
        public ICollection<Car> Cars => carEntityList;
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
    }
}
