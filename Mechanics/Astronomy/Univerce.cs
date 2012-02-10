using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AstroPhysics.Astronomy
{
    class Univerce
    {
        private StarSystem[] systems;

        public Univerce(Form form)
        {
            systems = new StarSystem[] 
            { 
                StarSystem.SunSolarSystem,
                StarSystem.MercurySystem,
                StarSystem.VenusSystem,
                StarSystem.EarthSystem,
                StarSystem.MarsSystem,
                StarSystem.JupiterSystem,
                StarSystem.SaturnSystem,
                StarSystem.UranusSystem,
                StarSystem.NeptuneSystem
            };

            //set all systems for and form bounds
            for (int i = 0; i < systems.Length; i++)
            {
                systems[i].Form = form;
                systems[i].FormBounds = form.Bounds;
            }
            //show the first system
            systems[0].Enabled = true;
        }

        public StarSystem CurrentSystem
        {
            get
            {
                for (int i = 0; i < systems.Length; i++)
                {
                    if (systems[i].Enabled)
                    {
                        return systems[i];
                    }
                }
                return null;
            }
        }

        public void Tick()
        {
            CurrentSystem.Tick(); // this may be all systems
        }

        public void Draw(Graphics g)
        {
            CurrentSystem.Draw(g);
        }

        public void SetAllBounds(Rectangle bounds)
        {
            foreach (StarSystem system in systems)
            {
                system.FormBounds = bounds;
            }
        }

        public void ChangeSpeedModiffer(float speed)
        {
            foreach (StarSystem system in systems)
            {
                system.SpeedModifer = speed;
            }
        }
    }
}
