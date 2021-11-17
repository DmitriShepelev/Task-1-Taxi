using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Types
{
    // TODO. Develop a type for a route taxi
    class MiniBus : KindOfCars
    {
        public override KindOfCars Type => this;
    }
}
