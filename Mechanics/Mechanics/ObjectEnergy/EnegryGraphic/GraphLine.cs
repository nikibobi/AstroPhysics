using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.ObjectEnergy//.EnegryGraphic
{
    class GraphLine
    {
        private const int MAX_POINTS = 100;

        private List<float> points;
        public Color Color { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public GraphLine(Color color)
        {
            points = new List<float>();
            this.Color = color;
        }

        public void AddPoint(float value)
        {
            if (points.Count >= MAX_POINTS)
            {
                points.RemoveAt(0);
            }
            points.Add(value);
        }

        public void Draw(Graphics g)
        {
            for (int x = 0; x < points.Count; x++)
            {
                g.DrawPolygon(new Pen(Color), new PointF[] { new PointF(X + x, Y + points[x]) });
            }
        }
    }
}
