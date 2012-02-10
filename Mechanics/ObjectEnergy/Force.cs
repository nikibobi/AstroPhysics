using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy
{
    class Force : Vector
    {
        //private static readonly Color Color = Color.Red;
        public Force()
            : base()
        { }

        public Force(float value, float angle)
            : base(value, angle)
        {
        }

        /// <summary>
        /// Applies this force to a specified object
        /// </summary>
        /// <param name="toObject">The specified object</param>
        public void Apply(IForceable toObject)
        {
            float accelerationValue = this.Value / toObject.Mass; // F = m.a  ==> a = F/m
            float accelerationAngle = (this.Angle + toObject.Acceleration.Angle) / 2; // the angle between 2 angles
            toObject.Acceleration = new Vector(accelerationValue, accelerationAngle);
        }
    }
}
