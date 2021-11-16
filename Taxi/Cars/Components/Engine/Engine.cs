using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Cars.Components.Engine
{
  public abstract  class Engine
    {
        public abstract Engine EngineType { get; protected set; }
    }
}
