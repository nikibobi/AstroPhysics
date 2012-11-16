using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Базов клас за физично тяло
    /// </summary>
    class Object : ITickable, IForceable
    {
        //consts
        private const float g = 9.80665f; //zemno uskorenie
        private const float ScaleHeigthToY = 7.5f;

        //private fields
        private float x;
        private float y;
        private float volume;
        private float mass;
        private Vector acceleration;
        private Force force;
        private Vector speed;
        private Vector initalSpeed;
        private float angleInRadians;
        private Material material;
        private Size imageSize;
        private Rectangle bounds;

        /// <summary>
        /// Създава физичен обект по дадени параметри
        /// </summary>
        /// <param name="image">Картинка представляваща обекта визуално</param>
        /// <param name="material">Материала от който е създаден обекта</param>
        /// <param name="X">X координатата където се намира обекта в 2D пространството</param>
        /// <param name="Y">Y координатата където се намира обекта в 2D пространството</param>
        /// <param name="bounds">Стените на пространството в което е този обект</param>
        public Object(Image image, Material material, float X, float Y, Rectangle bounds)
        {
            this.Image = image;
            this.X = X;
            this.Y = Y;
            this.bounds = bounds;
            this.imageSize = new Size(0, 0);
            this.Material = material;
            this.Volume = Image.Width;
            this.AngleInRadians = 0;
            this.Speed = new Vector(0, this.AngleInRadians);
            this.InitalSpeed = new Vector(0, this.AngleInRadians);
            this.Force = new Force(0, this.AngleInRadians);
            this.Acceleration = new Vector(0, this.AngleInRadians);
            this.UseGravity = false;
        }

        //properties
        /// <summary>
        /// X координатата на обекта
        /// </summary>
        public float X
        {
            get
            {
                return x + imageSize.Width / 2;
            }
            set
            {
                x = value - imageSize.Width / 2;
                if (x + imageSize.Width > bounds.Right)
                {
                    x = bounds.Right - imageSize.Width;
                    Speed = new Vector();
                    Acceleration = new Vector();
                    Force = new Force();
                }
                else if (x < bounds.Left)
                {
                    x = bounds.Left;
                    Speed = new Vector();
                    Acceleration = new Vector();
                    Force = new Force();
                }
            }
        }
        /// <summary>
        /// Y координатата на обекта
        /// </summary>
        public float Y
        {
            get
            {
                return y + imageSize.Height / 2;
            }
            set
            {
                y = value - imageSize.Height / 2;
                if (y + imageSize.Height > bounds.Bottom)
                {
                    y = bounds.Bottom - imageSize.Height;
                    Speed = new Vector();
                    Acceleration = new Vector();
                    Force = new Force();
                }
                else if (y < bounds.Top)
                {
                    y = bounds.Top;
                    Speed = new Vector();
                    Acceleration = new Vector();
                    Force = new Force();
                }
            }
        }

        /// <summary>
        /// Материала от който е създаден обекта
        /// </summary>
        public Material Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }
        /// <summary>
        /// Обема на обекта [V]
        /// </summary>
        public float Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                mass = volume * material.Density;
                imageSize.Width = (int)volume;
                imageSize.Height = (int)volume;
            }
        }
        /// <summary>
        /// Масата на обекта [m]
        /// </summary>
        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
                Volume = mass / material.Density;
            }
        }

        /// <summary>
        /// Ускорението на обекта [a]
        /// </summary>
        public Vector Acceleration
        {
            get
            {
                return acceleration;
            }
            set
            {
                acceleration = value;
            }
        }
        /// <summary>
        /// Силата приложена в/у обекта
        /// </summary>
        public Force Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
            }
        }
        /// <summary>
        /// Скоростта на обекта [V]
        /// </summary>
        public Vector Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        /// <summary>
        /// Началната скорост на обекта [V0]
        /// </summary>
        public Vector InitalSpeed
        {
            get
            {
                return initalSpeed;
            }
            set
            {
                initalSpeed = value;
            }
        }
        /// <summary>
        /// Височината на която се намира обекта [h]
        /// </summary>
        public float Height
        {
            get
            {
                return (bounds.Height - y - imageSize.Height) / ScaleHeigthToY;
            }
        }
        /// <summary>
        /// Ъгълът на движение на обекта
        /// </summary>
        public float AngleInRadians
        {
            get
            {
                return angleInRadians;
            }
            set
            {
                angleInRadians = value;
            }
        }

        //Energyes
        /// <summary>
        /// Кинетичната енергия на обекта [Ek]( Ek = (m*V^2)/2 )
        /// </summary>
        public float KineticEnergy
        {
            get
            {
                return (mass * speed.Value * speed.Value) / 2;
            }
        }
        /// <summary>
        /// Потенциалната енергия на обекта [Ep] ( Ep = m*g*h )
        /// </summary>
        public float PotentialEnergy
        {
            get
            {
                return mass * g * Height;
            }
        }
        /// <summary>
        /// Механичната енергия на обекта [Em] ( Em = Ek + Ep )
        /// </summary>
        public float MechanicEnergy
        {
            get
            {
                return KineticEnergy + PotentialEnergy;
            }
        }

        //other misc
        /// <summary>
        /// Картинката представляваща визуално обекта
        /// </summary>
        public Image Image { get; private set; }
        /// <summary>
        /// Областта в която може да цъкаме с мишката
        /// </summary>
        public Rectangle ClickBox
        {
            get
            {
                return new Rectangle((int)x, (int)y, imageSize.Width, imageSize.Height);
            }
        }
        /// <summary>
        /// Точка представляваща координатите на обекта
        /// </summary>
        public Point Location
        {
            get
            {
                return new Point((int)X, (int)Y);
            }
        }
        /// <summary>
        /// Дали обекта се влияе от Земното притегляне или не
        /// </summary>
        public bool UseGravity { get; set; }

        /// <summary>
        /// Обновява координатите на обекта в зависимост физичните му параметри
        /// </summary>
        public void Tick()
        {
            if (UseGravity)
            {
                Force = new Force(Force + Force.G);
                Force.Apply(this);
            }
            else
            {
                Force.Apply(this);
            }
            Speed.Value = InitalSpeed.Value + Acceleration.Value;
            //s = u + 1/2 * a;
            X += InitalSpeed.X + 0.5f * Acceleration.X;
            Y += InitalSpeed.Y + 0.5f * Acceleration.Y;
        }

        /// <summary>
        /// Рисува обекта
        /// </summary>
        /// <param name="g">Graphics обект използван за рисуването на обекта</param>
        public void Draw(Graphics g)
        {
            Size elipseSize = new Size((int)(imageSize.Width - imageSize.Width * 0.03), (int)(imageSize.Height - imageSize.Height * 0.03));
            Rectangle elipseRect = new Rectangle(new Point((int)(x + 3 * 0.03), (int)(y + 3 * 0.03)), elipseSize);
            g.FillEllipse(material.SolidBrush, elipseRect);

            g.DrawImage(Image, x, y, imageSize.Width, imageSize.Height);

            //debug 
            //Force.G.Draw(g, Location, Color.Red);
            //Force.Draw(g, Location, Color.Black);
        }
    }
}
