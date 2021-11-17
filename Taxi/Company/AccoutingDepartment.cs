using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Company
{
    class AccoutingDepartment
    {
        private VehicleFleet instance;
        public AccoutingDepartment()
        {
            instance = VehicleFleet.Instance;
        }

        public decimal TotalCostOfFleet()
        {
            return instance.Cars.Sum(x => x.Cost);
        }
    }
}
