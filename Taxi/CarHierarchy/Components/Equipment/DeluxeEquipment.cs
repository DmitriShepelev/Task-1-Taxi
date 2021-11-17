using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Components.Equipment
{
    class DeluxeEquipment : Equipment
    {
        public override Equipment EquipmentType => this;
        public override string ToString()
        {
            return $"Deluxe Equipment";
        }
    }
}
