using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.Particles
{
    class Particle
    {
        private int ticks;
        private float alpha;
        private float alphaDecreace;

        public PointF Location { get; private set; }
        public Color Color { get; private set; }
        public bool Removing { get; private set; }

        //ticks = length
        public Particle(int ticks, float x, float y, Color color)
        {
            this.ticks = ticks;
            this.Location = new PointF(x, y);
            this.Color = color;
            this.alpha = color.A;
            this.alphaDecreace = 255f / ticks;
        }

        public void Tick()
        {
            ticks--;
            alpha -= alphaDecreace;
            if (ticks <= 0 || alpha <= 0)
            {
                Removing = true;
            }
            Color = Color.FromArgb((int)alpha, Color);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color, 1f), Location.X, Location.Y, 1, 1);
        }
    }
}
