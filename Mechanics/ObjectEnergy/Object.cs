using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AstroPhysics.ObjectEnergy
{
    class Object
    {
        //consts
        private const float g = 9.80665f; //zemno uskorenie
        private const float ScaleHeigthToY = 7.5f;

        //private fields
        private float x;
        private float y;
        private float volume;
        private float mass;
        private Vector acceleration; // Vector
        private Vector force; // Vector
        private Vector speed; // Vector
        private Vector initalSpeed; // Vector
        private float angleInRadians;
        private Material material;
        private Size imageSize;
        private Rectangle bounds;

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
            this.Force = new Vector(0, this.AngleInRadians);
            this.Acceleration = new Vector(0, this.AngleInRadians);
        }

        //properties
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
                }
                else if (x < bounds.Left)
                {
                    x = bounds.Left;
                }
            }
        }
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
                }
                else if (y < bounds.Top)
                {
                    y = bounds.Top;
                }
            }
        }
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
        public Vector Acceleration
        {
            get
            {
                return acceleration;
            }
            private set
            {
                acceleration = value;
            }
        }
        public Vector Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
                initalSpeed = speed;
                Acceleration = force / mass;
            }
        }
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
        public float Height
        {
            get
            {
                return (bounds.Height - y - imageSize.Height) / ScaleHeigthToY;
            }
        }
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
        public float KineticEnergy
        {
            get
            {
                return (mass * speed.Value * speed.Value) / 2;
            }
        }
        public float PotentialEnergy
        {
            get
            {
                return mass * g * Height;
            }
        }
        public float MechanicEnergy
        {
            get
            {
                return KineticEnergy + PotentialEnergy;
            }
        }

        //other misc
        public Image Image { get; private set; }
        public Rectangle ClickBox
        {
            get
            {
                return new Rectangle((int)x, (int)y, imageSize.Width, imageSize.Height);
            }
        }
        public Point Location
        {
            get
            {
                return new Point((int)X, (int)Y);
            }
        }

        public void Tick()
        {
            speed = initalSpeed + acceleration;
            X += initalSpeed.X + 0.5f * acceleration.X;
            Y += initalSpeed.Y + 0.5f * acceleration.Y;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(material.SolidBrush, new Rectangle(new Point((int)x, (int)y), imageSize));
            g.DrawImage(Image, x, y, imageSize.Width, imageSize.Height);
        }
    }
}
