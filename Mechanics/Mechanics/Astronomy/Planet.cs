using System;
using System.Drawing;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    class Planet : IAstroObject
    {
        //consts
        private static readonly Font NameFont = new Font("Comic Sans MS"/* <- font name */, 13);

        //private fields
        private float x;
        private float y;
        private float distanceFromSun;
        private float angleInDegrees;
        private float angleInRadians;
        private readonly float degreesAddedEachTick;
        private readonly bool isClockwiseRotation;
        private readonly float initalAngle;
        private PointF rotationCenter;
        private readonly Orbit orbit;
        private readonly PlanetInfo planetInfo;

        //ctors
        public Planet()
        {
            SpeedModiffer = 1.0f;
            ImageScale = 1.0f;
            orbit = new Orbit();
        }
        public Planet(Image image, PlanetInfo planetInfo, float degreesAddedEachTick, float initalAngle)
            : this()
        {
            this.planetInfo = planetInfo;
            this.Name = planetInfo.Name;
            this.isClockwiseRotation = planetInfo.Clockwise;
            this.Image = image;
            this.degreesAddedEachTick = degreesAddedEachTick;
            this.initalAngle = initalAngle;
            this.angleInDegrees = initalAngle;
        }

        //properties
        public string Name { get; private set; }
        public Image Image { get; private set; }
        public float X
        {
            get
            {
                return x + Image.Width * ImageScale / 2f;
            }
            private set
            {
                x = value - Image.Width * ImageScale / 2f;
            }
        }
        public float Y
        {
            get
            {
                return y + Image.Height * ImageScale / 2f;
            }
            private set
            {
                y = value - Image.Height * ImageScale / 2f;
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
        public bool Enabled { get; set; }
        public PlanetInfo PlanetInfo
        {
            get
            {
                return planetInfo;
            }
        }
        public float SpeedModiffer { get; set; }
        public bool IsMouseOver { get; private set; }
        public float ImageScale { get; set; }

        //methods

        public void Tick()
        {
            CheckMouseInput();
            //TODO: maybe remove this maybe not ill rape you anyway
            //if (IsMouseOver)
            //{
            //    Cursor.Current = Cursors.Hand;
            //}
            Rotate();
        }

        public void Draw(Graphics g)
        {
            if (Enabled)
            {
                //draw the orbit
                orbit.Draw(g);

                PointF pointToText = new PointF(x + Image.Width * ImageScale / 4f, y + Image.Height * ImageScale);
                //draw the planet
                g.DrawImage(Image, x, y, Image.Width * ImageScale, Image.Height * ImageScale);
                if (IsMouseOver)
                {
                    //draw mouse over effect
                    g.DrawImage(Resources.MouseOver2, x, y, Image.Width * ImageScale, Image.Height * ImageScale);
                }
                //draw planet name
                g.DrawString(Name, NameFont, new SolidBrush(Color.White), pointToText); //maybo move below and allways hsow text
            }
        }

        private void Rotate()
        {
            X = distanceFromSun * (float)Math.Cos(angleInRadians) + rotationCenter.X;
            Y = distanceFromSun * (float)Math.Sin(angleInRadians) + rotationCenter.Y;
            if (Math.Abs(degreesAddedEachTick * SpeedModiffer - 0) > 0.001f) //if the rotation speed is not too small
            {
                angleInRadians = angleInDegrees * (float)(Math.PI / 180);

                if (!isClockwiseRotation)
                {
                    angleInDegrees -= degreesAddedEachTick * SpeedModiffer;
                }
                else
                {
                    angleInDegrees += degreesAddedEachTick * SpeedModiffer;
                }
            }
        }

        private void CheckMouseInput()
        {
            if (!Enabled)
                return;
            CheckMouseOver();
        }

        private void CheckMouseOver()
        {
            Rectangle imageClickbox = new Rectangle(new Point((int)x, (int)y), new Size((int)(Image.Size.Width * ImageScale), (int)(Image.Size.Height * ImageScale)));
            Rectangle mouseClickbox = new Rectangle(Input.Mouse.Position, new Size(1, 1));
            IsMouseOver = mouseClickbox.IntersectsWith(imageClickbox);
        }

        public void RestartPosition()
        {
            angleInDegrees = initalAngle;
        }
    }
}
