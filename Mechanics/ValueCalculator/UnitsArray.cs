using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.ValueCalculator
{
    /// <summary>
    /// This calss is only for an array of the enumeration Units.
    /// </summary>
    static class UnitS
    {
        public static Units[] Array = (Units[])Enum.GetValues(typeof(Units));
    }
}
