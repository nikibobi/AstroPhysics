using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AstroPhysics.Particles
{
    class Trail
    {
        private List<Particle> particles;
        private float maxLength;
        private int trailWidth;
        private float angleInDegrees;
        private float angleInRadians;
        private float x;
        private float y;

        public PointF Location { get; set; }
        public Color Color { get; set; }
        public float AngleInDegrees
        {
            get
            {
                return this.angleInDegrees;
            }
            set
            {
                this.angleInDegrees = value;
            }
        }

        //inplement
        public Trail(float angleInDegrees, int trailWidth, float maxLength, float x, float y, Color color)
        {
            particles = new List<Particle>();
            this.angleInDegrees = angleInDegrees;
            this.trailWidth = trailWidth;
            this.maxLength = maxLength;
            this.Location = new PointF(x, y);
            this.x = x;
            this.y = y;
            this.Color = color;
        }

        //inplement
        public void Tick()
        {
            removeRemainingParticles();
            addNewParticle();
            tickParticles();
        }

        //good
        public void Draw(Graphics g)
        {
            foreach (Particle particle in particles)
            {
                //particle.Draw(g);
            }
        }

        //good
        private void tickParticles()
        {
            foreach (Particle particle in particles)
            {
                particle.Tick();
            }
        }

        //inplement
        private void addNewParticle()
        {
            Particle particle;
            angleInRadians = (float)(Math.PI / 180) * angleInDegrees;
            x = (float)Math.Cos(angleInRadians) + Location.X;
            y = (float)Math.Sin(angleInRadians) + Location.Y;
            for (int i = 0; i < trailWidth; i++)
            {
                particle = new Particle((int)maxLength, Location.X + i*x, Location.Y + i*y, Color);
                particles.Add(particle);
            }
        }

        //good
        private void removeRemainingParticles()
        {
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                Particle particle = particles[i];
                if (particle.Removing)
                {
                    particles.Remove(particle);
                }
            }
        }
    }
}
