using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Components.Body
{
    class Truck : Body
    {
        public override Body Type => this;
        public override string ToString()
        {
            return $"Truck";
        }
    }
}
