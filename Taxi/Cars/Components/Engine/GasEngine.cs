using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Cars.Components.Engine
{
    class GasEngine : Engine
    {
        public override Engine EngineType { get => this; protected set =>  new GasEngine(); }
    }
}
