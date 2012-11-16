using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Клас за физична сила (Унаследява Vector)
    /// </summary>
    class Force : Vector
    {
        /// <summary>
        /// Константната сила Земно Притегляне
        /// </summary>
        public static readonly Force G = new Force(9.80665f, (float)Math.PI / 2);

        public Force()
            : base()
        { }

        /// <summary>
        /// Създава сила по зададени дължина и ъгъл
        /// </summary>
        /// <param name="value">Стойността на силата(дължината на вектора)</param>
        /// <param name="angle">Ъгълът на силата</param>
        public Force(float value, float angle)
            : base(value, angle)
        {
        }
        /// <summary>
        /// Създава сила по даден вектор
        /// </summary>
        /// <param name="vector">Вектора по който ще бъде създадена силата</param>
        public Force(Vector vector)
            : base(vector.Value, vector.Angle)
        {
        }

        /// <summary>
        /// Прилага силата в/у даден IForceable обект
        /// </summary>
        /// <param name="toObject">Обекта в/у който прилагаме силата</param>
        public void Apply(IForceable toObject)
        {
            toObject.Acceleration = this / toObject.Mass;    //a = F / m
        }

        //probably a better solution
        //public void Apply(Force force)
        //{
        //    force = (Force)(force + this);
        //}
    }
}
