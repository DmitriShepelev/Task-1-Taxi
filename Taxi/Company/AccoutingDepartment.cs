using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Interfaces;

namespace Taxi.Company
{
    class AccoutingDepartment : IAccoutingDepartment
    {
        private VehicleFleet vehicleFleet;
        public AccoutingDepartment(VehicleFleet vehicleFleet)
        {
            this.vehicleFleet = vehicleFleet;
        }

        public decimal GetTotalCostOfFleet()
        {
            return vehicleFleet.Cars.Sum(x => x.Cost);
        }
    }
}
