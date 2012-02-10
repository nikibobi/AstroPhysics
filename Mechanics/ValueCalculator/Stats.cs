using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.ValueCalculator
{
    class Stats
    {
        private class Stat
        {
            public double Modifier;  // 10^n of the normal
            public double Value;
        }

        private Dictionary<Units, Stat> stats;

        public Stats()
        {
            stats = new Dictionary<Units, Stat>();
            foreach (Units unit in UnitS.Array)
            {
                stats.Add(unit, new Stat() { Modifier = Math.Pow(10, (int)unit) });
            }
        }

        public double GetStat(Units unit)
        {
            return stats[unit].Value;
        }

        public void SetStat(Units unitToSet, double value)
        {
            foreach (Units unit in UnitS.Array)
            {
                stats[unit].Value = value * (stats[unitToSet].Modifier / stats[unit].Modifier);
            }
        }
    }
}
