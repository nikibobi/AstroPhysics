using System;

namespace AstroPhysics.ValueCalculator
{
    /// <summary>
    /// Помощен клас за енумерацията Units
    /// </summary>
    static class UnitS
    {
        /// <summary>
        /// Единствената член-променлива е масив запълнен с различните стойности на enum-а Units
        /// </summary>
        public static Units[] Array = (Units[])Enum.GetValues(typeof(Units));
    }
}
