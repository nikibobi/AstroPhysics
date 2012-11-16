using System.Drawing;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    /// <summary>
    /// This class is for the information image of each planet
    /// </summary>
    partial class PlanetInfo
    {
        private readonly Image background;
        private readonly Image photo;
        private readonly string textInfo;
        private readonly string numbersInfo;

        private readonly SolidBrush brush;
        private readonly Font titleNameFont;
        private readonly Font textInfoFont;
        private readonly Font numbersInfoFont;

        public PlanetInfo()
        {
            background = Resources.PlanetInfo;
            brush = new SolidBrush(Color.FromArgb(54, 50, 66));
            titleNameFont = new Font("Arial Black", 18f, FontStyle.Bold);
            textInfoFont = new Font("Arial", 11f);
            numbersInfoFont = new Font("Arial", 16f);
        }

        public PlanetInfo(Image photo, Image icon, string titleName, string textInfo, string numbersInfo,bool clockwise = false)
            : this()
        {
            this.photo = photo;
            this.Icon = icon;
            this.Name = titleName;
            this.textInfo = textInfo;
            this.numbersInfo = numbersInfo;
            this.Clockwise = clockwise;
        }

        public bool Visible { get; set; }
        public string Name { get; private set; }
        public bool Clockwise { get; set; }
        public Image Icon { get; private set; }

        public void Draw(Graphics g)
        {
            if (Visible)
            {
                //draw the background
                g.DrawImage(background, 0, 0);
                //draw the photo
                g.DrawImage(photo, 81, 111, 483 - 81, 512 - 111);
                //draw the title
                g.DrawString(Name, titleNameFont, brush, new RectangleF(81, 68, 277 - 81, 98 - 68));
                //draw the text
                g.DrawString(textInfo, textInfoFont, brush, new RectangleF(83, 527, 675 - 83, 647 - 527));
                //draw the numbers
                g.DrawString(numbersInfo, numbersInfoFont, brush, new RectangleF(520, 111, 805 - 520, 512 - 111));
                //draw the icon
                g.DrawImage(Icon, 687, 529, 805 - 687, 647 - 529);
            }
        }
    }
}
