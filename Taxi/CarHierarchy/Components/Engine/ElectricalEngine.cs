using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Components.Engine
{
    public class ElectricalEngine : Engine
    {
        public override Engine EngineType => this;
    }
}
