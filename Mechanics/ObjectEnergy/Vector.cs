using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy
{
    class Vector
    {
        private float value;
        private float angle; //in radians

        /// <summary>
        /// Creates a zero vector (0,0)
        /// </summary>
        public Vector()
            : this(0, 0)
        {
        }

        //normal coordinates
        /// <summary>
        /// Creates a vector with Cartesian cooordinates
        /// </summary>
        /// <param name="pos">A point representing the coordinates (x and y) of the vector</param>
        public Vector(PointF pos)
            : this((float)Math.Sqrt(pos.X * pos.X + pos.Y * pos.Y), (float)Math.Atan(pos.Y / pos.X))
        {
        }

        //polar coordinates
        /// <summary>
        /// Creates a vector with Polar coordinates
        /// </summary>
        /// <param name="value">The lenght of the vector</param>
        /// <param name="angle">The angle(in radians) of the vector</param>
        public Vector(float value, float angle)
        {
            this.Value = value;
            this.Angle = angle;
        }


        /// <summary>
        /// The lenght/magnitude/norm of the vector
        /// </summary>
        public float Value
        {
            get
            {
                return this.value;
            }
            private set
            {
                this.value = value;
            }
        }
        /// <summary>
        /// Angle in Radians
        /// </summary>
        public float Angle
        {
            get
            {
                return this.angle;
            }
            private set
            {
                this.angle = value;
            }
        }

        public float X
        {
            get
            {
                return Value * (float)Math.Cos(Angle);
            }
        }
        public float Y
        {
            get
            {
                return Value * (float)Math.Sin(Angle);
            }
        }

        /// <summary>
        /// Normalizes the vector
        /// </summary>
        public void Normalize()
        {
            this.Value = 1;
        }

        /// <summary>
        /// Return new normalize vector
        /// </summary>
        /// <returns>The normalized vector</returns>
        public Vector GetNormalized()
        {
            Vector result = new Vector(1, this.angle);
            return result;
        }

        #region Operators

        //vector product of the sum of 2 vectors
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Vector result = Vector.Addition(vector1, vector2);
            return result;
        }

        //the oposite vector of this vector
        public static Vector operator -(Vector vector)
        {
            Vector result = new Vector(vector.Value, (float)Math.PI + vector.Angle); // 180 + angle is the opposite angle
            return result;
        }

        //vector product of the subtraction of2 vectors
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            Vector result = vector1 + (-vector2);
            return result;
        }

        //scalar product of 2 vectors
        public static float operator *(Vector vector1, Vector vector2)
        {
            float angle = vector1.Angle - vector2.Angle;
            float result = (float)(vector1.Value * vector2.Value * Math.Cos(angle));
            return result;
        }

        //scalar multiply a vector
        public static Vector operator *(double number, Vector vector)
        {
            Vector result = Vector.ScalarMultiply(number, vector);
            return result;
        }

        //scalar multiply a vector (inverted order)
        public static Vector operator *(Vector vector, double number)
        {
            Vector result = Vector.ScalarMultiply(number, vector);
            return result;
        }

        public static Vector operator /(Vector vector, double number)
        {
            Vector result = Vector.ScalarMultiply(1.0 / number, vector);
            return result;
        }

        #endregion

        private static Vector Addition(Vector vector1, Vector vector2)
        {
            float x = vector1.X + vector2.X;
            float y = vector1.Y + vector2.Y;
            float value = (float)Math.Sqrt(x * x + y * y);
            float angle = (float)Math.Atan(y / (x == 0 ? 1 : x)); //using a little chat here
            Vector result = new Vector(value, angle);
            return result;
        }
        private static Vector ScalarMultiply(double number, Vector vector)
        {
            float x = (float)Math.Abs(number) * vector.X;
            float y = (float)Math.Abs(number) * vector.Y;
            float value = (float)Math.Sqrt(x * x + y * y);
            Vector result = new Vector(value, vector.angle);
            if (number < 0)
                return -result;
            else
                return result;
        }
    }
}
