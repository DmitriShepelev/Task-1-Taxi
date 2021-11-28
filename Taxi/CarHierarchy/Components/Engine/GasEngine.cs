using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Components.Engine
{
    public class GasEngine : Engine
    {
        public override Engine EngineType => this;
        public override string ToString()
        {
            return $"Gas Engine";
        }
    }
}
