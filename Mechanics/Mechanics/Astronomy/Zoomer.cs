using System;
using System.Drawing;

namespace AstroPhysics.Astronomy
{
    class Zoomer
    {
        private int turns;
        private int curentTurn = 0;
        private double translateStep;
        private double translateAngle;
        private PointF start;
        private PointF end;
        private double zoomStart;
        private double zoomEnd;
        private double zoomCoeficent;

        public PointF Translation { get; private set; }
        public double Scale { get; private set; }

        public Zoomer(int turns, PointF start, PointF end, double zoomStart = 1.0, double zoomEnd = 2.0)
        {
            this.turns = turns;
            this.start = start;
            this.end = end;
            this.zoomStart = zoomStart;
            this.zoomEnd = zoomEnd;
            zoomCoeficent = Math.Pow(zoomEnd / zoomStart, 1.0 / turns);
            translateStep = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2)) / turns;
            translateAngle = Math.Atan2(end.Y - start.Y, end.X - start.X);

            Translation = start;
            Scale = zoomStart;
        }

        //thick and isFinished at the same time
        public bool Go()
        {
            curentTurn++;
            return Translate() && Zoom();
        }

        private bool Zoom()
        {
            if (curentTurn < turns)
            {
                Scale *= zoomCoeficent;
                return false;
            }

            Scale = zoomEnd;
            return true;
        }
        private bool Translate()
        {
            float xStep = (float)(Math.Cos(translateAngle) * translateStep);
            float yStep = (float)(Math.Sin(translateAngle) * translateStep);
            SizeF step = new SizeF(xStep, yStep);

            if (curentTurn < turns)
            {
                Translation += step;
                return false;
            }

            Translation = end;
            return true;
        }
    }
}
