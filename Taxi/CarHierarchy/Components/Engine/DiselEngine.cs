using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.CarHierarchy.Components.Engine
{
    public class DiselEngine : Engine
    {
        public override Engine EngineType => this;
        public override string ToString()
        {
            return $"Disel Engine";
        }
    }
}
