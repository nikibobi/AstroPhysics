using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AstroPhysics.Properties;

namespace AstroPhysics.ObjectEnergy
{
    class Material
    {
        //add materials here
        public static Material Gold = new Material(0.1932f, Color.FromArgb(255, 215, 101));
        public static Material Iron = new Material(0.0787f, Color.FromArgb(96, 96, 94));
        public static Material Copper = new Material(0.0896f, Color.FromArgb(213, 152, 121));
        public static Material Silver = new Material(0.1049f, Color.FromArgb(189, 189, 189));
        public static Material Lead = new Material(0.1136f, Color.FromArgb(109, 128, 134));

        //maybe add image to it
        public Material(float density, Color color)
        {
            this.Density = density;
            this.SolidBrush = new SolidBrush(color);
        }

        public float Density { get; private set; }
        public SolidBrush SolidBrush { get; private set; }
    }
}
