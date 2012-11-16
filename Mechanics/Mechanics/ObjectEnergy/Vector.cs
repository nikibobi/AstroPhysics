using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Клас за математическия обект Вектор
    /// </summary>
    class Vector
    {
        private float value;
        private float angle; //in radians

        /// <summary>
        /// Създава вектора (0,0)
        /// </summary>
        public Vector()
            : this(0, 0)
        {
        }

        //normal coordinates
        /// <summary>
        /// Създава вектор в декартова координатна система
        /// </summary>
        /// <param name="pos">Точка с която ще се създаде вектор</param>
        public Vector(PointF pos)
            : this((float)Math.Sqrt(pos.X * pos.X + pos.Y * pos.Y), (float)Math.Atan(pos.Y / pos.X))
        {
        }
        //polar coordinates
        /// <summary>
        /// Създава вектор в полярна координатна система
        /// </summary>
        /// <param name="value">Дължината на вектора</param>
        /// <param name="angle">Ъгълът на вектора(в радиани) на вектора</param>
        public Vector(float value, float angle)
        {
            this.Value = value;
            this.Angle = angle;
        }


        /// <summary>
        /// Дължината на вектора
        /// </summary>
        public float Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        /// <summary>
        /// Ъгълът на вектора(в радиани)
        /// </summary>
        public float Angle
        {
            get
            {
                return this.angle;
            }
            set
            {
                this.angle = value;
            }
        }

        /// <summary>
        ///  X координата
        /// </summary>
        public float X
        {
            get
            {
                return Value * (float)Math.Cos(Angle); // x = r*cos(a)              
            }
            set
            {
                this.Value = (float)(value / Math.Cos(Angle)); // r = x/cos(a)
            }
        }
        /// <summary>
        /// Y координата
        /// </summary>
        public float Y
        {
            get
            {
                return Value * (float)Math.Sin(Angle); // y = r*sin(a)              
            }
            set
            {
                this.Value = (float)(value / Math.Sin(Angle)); // r = y/sin(a)
            }
        }

        /// <summary>
        /// Нормализира вектора
        /// </summary>
        /// <remarks>
        /// Нормализирането на вектор става като вектора
        /// се раздели на стойността си и това дава винаги
        /// стойност на вектора 1.
        /// </remarks>
        public void Normalize()
        {
            this.Value = 1;
        }

        /// <summary>
        /// Създава нормализиран вектор
        /// </summary>
        /// <returns>Нормализирания вектор</returns>
        public Vector GetNormalized()
        {
            Vector result = this / this.Value;
            return result;
        }

        /// <summary>
        /// Чартае стрелка представляваща визъално вектора
        /// </summary>
        /// <param name="g">Graphics обект който да бъде използван за чартането на вектора</param>
        /// <param name="location">Точка на екрана която представлява началото на координатната система</param>
        /// <param name="color">Цвета в който ще се чертае вектора</param>
        public void Draw(Graphics g, Point location, Color color)
        {
            Pen pen = new Pen(color);
            pen.Width = 5f;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;

            Vector start = new Vector(location);
            Vector end = start + this;

            PointF startPopint = new PointF(start.X, start.Y);
            PointF endPoint = new PointF(end.X, end.Y);

            g.DrawLine(pen, startPopint, endPoint);
        }

        #region Operators

        /// <summary>
        /// Индексатор който съответния компонент на вектора
        /// </summary>
        /// <param name="component">Компонента който да върне(0 за X; 1 за Y)</param>
        /// <returns>Стойността на компонента</returns>
        public float this[int component]
        {
            get
            {
                if (component == 0)
                {
                    return this.X;
                }
                if (component == 1)
                {
                    return this.Y;
                }
                //if its not x nor y throw exeption
                throw new IndexOutOfRangeException("There is no vector value at " + component + "!");
            }
        }

        //vector product of the sum of 2 vectors
        /// <summary>
        /// Събира два вектора по математическата дефиниция
        /// </summary>
        /// <param name="vector1">Първия вектор</param>
        /// <param name="vector2">Втория вектор</param>
        /// <returns>Сбора от първия и втория вектор</returns>
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Vector result = Vector.Addition(vector1, vector2);
            return result;
        }

        //the oposite vector of this vector
        /// <summary>
        /// Вектор с отрицателна на дадения вектор стойност
        /// </summary>
        /// <param name="vector">Вектора който ще ползваме</param>
        /// <returns>Отрицанието на този вектор</returns>
        public static Vector operator -(Vector vector)
        {
            Vector result = new Vector(vector.Value, (float)Math.PI + vector.Angle); // 180 + angle is the opposite angle
            return result;
        }

        //vector product of the subtraction of2 vectors
        /// <summary>
        /// Изважда два вектора
        /// </summary>
        /// <param name="vector1">Вектора от който вадим</param>
        /// <param name="vector2">Вектора с който вадим</param>
        /// <returns>Вектор получен от разликата на двата вектора</returns>
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            Vector result = vector1 + (-vector2);
            return result;
        }

        //scalar product of 2 vectors
        /// <summary>
        /// Скаларно произведение на два вектора
        /// </summary>
        /// <param name="vector1">Първия вектор</param>
        /// <param name="vector2">Втория вектор</param>
        /// <returns>Скаларното произведение(число) на два вектора</returns>
        public static float operator *(Vector vector1, Vector vector2)
        {
            float angle = vector1.Angle - vector2.Angle;
            float result = (float)(vector1.Value * vector2.Value * Math.Cos(angle));
            return result;
        }

        //scalar multiply a vector
        /// <summary>
        /// Умножение на вектор с число
        /// </summary>
        /// <param name="number">Числото с което умножаваме</param>
        /// <param name="vector">Вектора който умножаваме</param>
        /// <returns>Вектор резултат от умножението на вектора с число</returns>
        public static Vector operator *(double number, Vector vector)
        {
            Vector result = Vector.ScalarMultiply(number, vector);
            return result;
        }

        //scalar multiply a vector (inverted order)
        /// <summary>
        /// Умножение на вектор с число
        /// </summary>
        /// <param name="vector">Вектора който умножаваме</param>
        /// <param name="number">Числото с което умножаваме</param>
        /// <returns>Вектор резултат от умножението на вектора с число</returns>
        public static Vector operator *(Vector vector, double number)
        {
            return number * vector;
        }

        /// <summary>
        /// Делене вектор на число
        /// </summary>
        /// <param name="vector">Вектора който делим</param>
        /// <param name="number">Числото на което делим</param>
        /// <returns>Вектор резултат от деленето</returns>
        public static Vector operator /(Vector vector, double number)
        {
            Vector result = Vector.ScalarMultiply(1.0 / number, vector);
            return result;
        }

        public static bool operator true(Vector vector)
        {
            return Math.Abs(vector.Value - 0) > 0.00000001;
        }

        public static bool operator false(Vector vector)
        {
            return Math.Abs(vector.Value - 0) < 0.00000001;
        }

        #endregion

        private static Vector Addition(Vector vector1, Vector vector2)
        {
            float x = vector1.X + vector2.X;
            float y = vector1.Y + vector2.Y;
            float value = (float)Math.Sqrt(x * x + y * y);
            float angle = (float)Math.Atan2(y, x);
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
            return result;
        }
    }
}
