using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy
{
    static class Convertor
    {
        private const float distanceConstant = 10f; // 10 pix = 1 meter
        private const float timeConstant = 1000f; // 1000 ticks = 1 sec

        //returns meters from pixels
        public static float Meters(float pixels)
        {
            return pixels / distanceConstant;
        }
        //returns pxels from meters
        public static float Pixels(float meters)
        {
            return meters * distanceConstant;
        }
        public static float Seconds(float ticks)
        {
            return ticks / timeConstant;
        }
        public static float Ticks(float seconds)
        {
            return seconds * timeConstant;
        }

        /// <summary>
        /// Gives the value multiplied by the cos of the angle
        /// </summary>
        /// <param name="value">A specified value to be manipulated and returned (angle must be in radians)</param>
        /// <param name="angleInRadians">The angle for the cos function</param>
        /// <returns>The value multiplied by the cos if the angle</returns>
        public static float GetX(float value, float angleInRadians)
        {
            return value * (float)Math.Cos(angleInRadians);
        }

        /// <summary>
        /// Gives the value multiplied by the sin of the angle
        /// </summary>
        /// <param name="value">A specified value to be manipulated and returned (angle must be in radians)</param>
        /// <param name="angleInRadians">The angle for the sin function</param>
        /// <returns>The value multiplied by the sin if the angle</returns>
        public static float GetY(float value, float angleInRadians)
        {
            return value * (float)Math.Sign(angleInRadians);
        }

        /// <summary>
        /// Calculates the distance between 2 points
        /// </summary>
        /// <param name="point1">The first point</param>
        /// <param name="point2">The second point</param>
        /// <returns>The distance between the the first and the second point</returns>
        public static double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }
}
