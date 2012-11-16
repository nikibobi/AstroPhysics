using System.Drawing;
using System.Drawing.Drawing2D;

namespace AstroPhysics.Astronomy
{
    class Orbit
    {
        //consts
        private const uint COLOR = 0x30808080;
        private const float PEN_WIDTH = 3f;

        //backing fields
        private PointF center;
        private float radius;
        private readonly Image image;

        //ctors
        public Orbit(PointF center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public Orbit()
            : this(new PointF(0, 0), 0)
        {

        }
        public Orbit(Image image)
            : this()
        {
            this.image = image;
        }

        //properties
        public PointF Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        //methods
        public void Draw(Graphics g)
        {
            RectangleF rectF = new RectangleF(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            if (image == null)
            {
                Pen pen = new Pen(Color.FromArgb(unchecked((int) COLOR)), PEN_WIDTH) {DashStyle = DashStyle.Solid};
                g.DrawEllipse(pen, rectF);
            }
            else
            {
                g.DrawImage(image, rectF);
            }
        }
    }
}
