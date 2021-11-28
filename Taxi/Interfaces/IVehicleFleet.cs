using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.CarHierarchy;

namespace Taxi.Interfaces
{
    public interface IVehicleFleet
    {
        ICollection<Car> Cars { get; }

        void Add(Car carEntity);
        ICollection<Car> SortByConsumption();
        void ShowFleetToConsole();
        IEnumerable<Car> FindCarBySpeedRange(int startRange, int endRange);
    }
}
