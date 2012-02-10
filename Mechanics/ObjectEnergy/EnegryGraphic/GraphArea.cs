using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy//.EnegryGraphic
{
    class GraphArea
    {
        public List<GraphLine> Lines { get; set; }
        public float X
        {
            set
            {
                foreach (GraphLine line in Lines)
                {
                    line.X = value;
                }
            }
        }
        public float Y
        {
            set
            {
                foreach (GraphLine line in Lines)
                {
                    line.Y = value;
                }
            }
        }

        public GraphArea(float x, float y)
        {
            Lines = new List<GraphLine>();
            this.X = x;
            this.Y = y;
        }

        public void Draw(Graphics g)
        {
            foreach (GraphLine line in Lines)
            {
                line.Draw(g);
            }
        }
    }
}
