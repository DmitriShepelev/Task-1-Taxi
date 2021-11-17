using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Types
{
    // TODO. Develop a type for private freight transport
    class MovingVan : KindOfCars
    {
        public override KindOfCars Type => this;
    }
}
