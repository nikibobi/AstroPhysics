using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AstroPhysics.Particles;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    class Planet
    {
        //consts
        private static readonly Font NameFont = new Font("Ariel"/* <- font name */, 13);

        //private fields
        private float x;
        private float y;
        private float distanceFromSun;
        private float angleInDegrees;
        private float angleInRadians;
        private float degreesAddedEachTick;
        private bool isClockwiseRotation;
        private bool enabled;
        private bool isMouseOver;
        private PointF rotationCenter;
        private Orbit orbit;
        private PlanetInfo planetInfo;

        //ctors
        public Planet()
        {
            SpeedModiffer = 1.0f;
            orbit = new Orbit();
        }
        public Planet(Image image,PlanetInfo planetInfo, float degreesAddedEachTick, bool clockwise)
            : this()
        {
            this.planetInfo = planetInfo;
            this.Name = planetInfo.Name;
            this.Image = image;
            this.degreesAddedEachTick = degreesAddedEachTick;
            this.isClockwiseRotation = clockwise;
        }

        //properties
        public string Name { get; private set; }
        public Image Image { get; private set; }
        public float X
        {
            get
            {
                return x + Image.Width / 2;
            }
            private set
            {
                x = value - Image.Width / 2;
            }
        }
        public float Y
        {
            get
            {
                return y + Image.Height / 2;
            }
            private set
            {
                y = value - Image.Height / 2;
            }
        }
        public PointF Location
        {
            get
            {
                return new PointF(X, Y);
            }
        }
        public PointF RotationCenter
        {
            get
            {
                return rotationCenter;
            }
            set
            {
                rotationCenter = value;
                orbit.Center = rotationCenter;
            }
        }
        public float DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
                orbit.Radius = distanceFromSun;
            }
        }
        public bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                if (Form != null)
                {
                    if (enabled)
                    {
                        Form.MouseClick += Form_MouseClick;
                        Form.MouseMove += Form_MouseMove;
                        Form.MouseWheel += Form_MouseWheel;
                    }
                    else
                    {
                        Form.MouseClick -= Form_MouseClick;
                        Form.MouseMove -= Form_MouseMove;
                        Form.MouseWheel -= Form_MouseWheel;
                    }
                }
            }
        }
        public PlanetInfo Info
        {
            get
            {
                return this.planetInfo;
            }
        }
        public StarSystem You { get; set; }
        public StarSystem Child { get; set; }
        public Form Form { get; set; }
        public float SpeedModiffer { get; set; }

        //methods
        public Planet SetChild(StarSystem child)
        {
            this.Child = child;
            return this;
        }

        public void Tick()
        {
            X = distanceFromSun * (float)Math.Cos(angleInRadians) + rotationCenter.X;
            Y = distanceFromSun * (float)Math.Sin(angleInRadians) + rotationCenter.Y;
            if (degreesAddedEachTick != 0)
            {
                angleInRadians = angleInDegrees * (float)(Math.PI / 180);

                if (isClockwiseRotation)
                {
                    angleInDegrees += degreesAddedEachTick * SpeedModiffer;
                }
                else
                {
                    angleInDegrees -= degreesAddedEachTick * SpeedModiffer;
                }
            }
        }

        public void Draw(Graphics g)
        {
            if (enabled)
            {
                //draw the orbit
                orbit.Draw(g);

                PointF pointToText = new PointF(x + Image.Width / 4, y + Image.Height);
                //draw the planet
                g.DrawImage(Image, x, y);
                if (isMouseOver)
                {
                    g.DrawImage(Resources.MouseOver2, x, y, this.Image.Width, this.Image.Height);
                }
                g.DrawString(Name, NameFont, new SolidBrush(Color.White), pointToText);
                //g.MeasureString(Name, NameFont);
            }
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (planetInfo.Visible)
                planetInfo.Visible = false;

            if (isMouseOver && e.Delta > 0)
            {
                //do the child here
                if (Child != null)
                {
                    StarSystem.SystemsStack.Push(You);
                    You.Enabled = false;
                    Child.Enabled = true;
                }
            }
            else if (/* isMouseOver && */e.Delta < 0)
            {
                //do the parent here
                if (StarSystem.SystemsStack.Count > 0)
                {
                    You.Enabled = false;
                    StarSystem.SystemsStack.Pop().Enabled = true;
                }
            }
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle imageClickbox = new Rectangle(new Point((int)x, (int)y), Image.Size);
            Rectangle mouseClickbox = new Rectangle(e.Location, new Size(1, 1));
            if (mouseClickbox.IntersectsWith(imageClickbox))
            {
                isMouseOver = true;
            }
            else
            {
                isMouseOver = false;
            }
        }
        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (planetInfo.Visible)
                {
                    planetInfo.Visible = false;
                }
                else if (isMouseOver)
                {
                    planetInfo.Visible = true;
                }
            }
        }
    }
}
