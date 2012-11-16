using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.ValueCalculator
{
    /// <summary>
    /// Клас съдържащ и работещ с всички мерни единици в енумерацията Units
    /// </summary>
    class Stats
    {
        /// <summary>
        /// Клас съдържащ информация за дадена мерна единица
        /// </summary>
        private class Stat
        {
            /// <summary>
            /// Число степен на 10 за съответната мерна единица
            /// </summary>
            public double Modifier;  // 10^n of the normal
            /// <summary>
            /// Стойността на мерната единица
            /// </summary>
            public double Value;
        }

        /// <summary>
        /// Речник със ключ мерна единица(Units) и стойност информация за мерна единица(Stat)
        /// </summary>
        private Dictionary<Units, Stat> stats;

        /// <summary>
        /// Инициализира речника stats и го запълва с всички стоиности на enum-а Units
        /// </summary>
        public Stats()
        {
            stats = new Dictionary<Units, Stat>();
            foreach (Units unit in UnitS.Array)
            {
                stats.Add(unit, new Stat() { Modifier = Math.Pow(10, (int)unit) });
            }
        }

        /// <summary>
        /// Връща стойността на числото в подадената мерна единица
        /// </summary>
        /// <param name="unit">Мерна единица от тип Units</param>
        /// <returns>Стойността на числото в тази единица</returns>
        public double GetStat(Units unit)
        {
            return stats[unit].Value;
        }

        /// <summary>
        /// Променя стойност в речника stats по зададените параметри
        /// </summary>
        /// <param name="unitToSet">В каква мерна единица е зададеното число</param>
        /// <param name="value">Самото число което задаваме</param>
        public void SetStat(Units unitToSet, double value)
        {
            foreach (Units unit in UnitS.Array)
            {
                stats[unit].Value = value * (stats[unitToSet].Modifier / stats[unit].Modifier);
            }
        }
    }
}
