using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    partial class StarSystem
    {
        private List<Planet> planets;
        private Form form;
        private Rectangle formBounds;

        public StarSystem(string name, Planet starSystemCenter, Image background)
        {
            this.Name = name;
            this.Background = background;
            planets = new List<Planet>();
            this.AddPlanet(starSystemCenter);
        }

        public string Name { get; private set; }
        public Image Background { get; private set; }
        public Form Form
        {
            get
            {
                return form;
            }
            set
            {
                form = value;
                foreach (Planet planet in planets)
                {
                    planet.Form = form;
                }
            }
        }
        public Rectangle FormBounds
        {
            get
            {
                return formBounds;
            }
            set
            {
                formBounds = value;
                scalePlanets();
            }
        }
        public bool Enabled
        {
            get
            {
                return planets[0].Enabled; //maybe has be changed... maybe remove the geter
            }
            set
            {
                foreach (Planet planet in planets)
                {
                    planet.Enabled = value;
                }
            }
        }
        public float SpeedModifer
        {
            set
            {
                foreach (Planet planet in planets)
                {
                    planet.SpeedModiffer = value;
                }
            }
        }

        public StarSystem AddPlanet(params Planet[] planetsToAdd)
        {
            foreach (Planet planet in planetsToAdd)
            {
                planets.Add(planet);
                planet.You = this;
            }
            return this;
        }

        public void Tick()
        {
            foreach (Planet planet in planets)
            {
                planet.Tick();
            }
        }

        public void Draw(Graphics g)
        {
            //draw background
            g.DrawImage(Background, Screen.PrimaryScreen.WorkingArea);
            //draw every planet in the system
            foreach (Planet planet in planets)
            {
                planet.Draw(g);
            }
            //draw the planet info if its visible
            foreach (Planet planet in planets)
            {
                if (planet.Info.Visible)
                {
                    planet.Info.Draw(g);
                }
            }
        }

        private void scalePlanets() //clean it
        {
            float distanceFromSun = 0;
            float halfBound = (formBounds.Width < formBounds.Height ? formBounds.Width : formBounds.Height) / 2; // the half bound witch is smaller used later for calculations
            float distanceFromSunPictures = planets[0].Image.Width / 2;
            for (int i = 1; i < planets.Count; i++)
            {
                distanceFromSunPictures += planets[i].Image.Width;
            }
            float distanceBetweenPlanets = (halfBound - distanceFromSunPictures) / planets.Count - 1;

            foreach (Planet planet in planets)
            {
                planet.RotationCenter = new PointF(formBounds.Width / 2, formBounds.Height / 2);
            }
            for (int i = 1; i < planets.Count; i++)
            {
                distanceFromSun += planets[i - 1].Image.Width / 2 + distanceBetweenPlanets + planets[i].Image.Width / 2;
                planets[i].DistanceFromSun = distanceFromSun;
            }
        }
    }
}
