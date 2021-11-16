using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Cars.Types
{
    abstract class CarEntity
    {
        abstract KindOfCars KindOfCars { get; set; }
        abstract FuelType FuelType { get; set; }
        abstract float EnginePower { get; set; } //? может перенести в двигатель? и тип топлива тоже?
    }
}
