using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    /// <summary>
    /// This class is for the information image of each planet
    /// </summary>
    partial class PlanetInfo
    {
        private Image background;
        private Image photo;
        private Image icon;
        private string titleName;
        private string textInfo;
        private string numbersInfo;
        private bool visible;

        private SolidBrush brush;
        private Font titleNameFont;
        private Font textInfoFont;
        private Font numbersInfoFont;

        public PlanetInfo()
        {
            this.background = Resources.PlanetInfo;
            this.brush = new SolidBrush(Color.FromArgb(54, 50, 66));
            this.titleNameFont = new Font("Arial Black", 18f, FontStyle.Bold);
            this.textInfoFont = new Font("Arial", 11f);
            this.numbersInfoFont = new Font("Arial", 16f);
        }

        public PlanetInfo(Image photo, Image icon, string titleName, string textInfo, string numbersInfo)
            : this()
        {
            this.photo = photo;
            this.icon = icon;
            this.titleName = titleName;
            this.textInfo = textInfo;
            this.numbersInfo = numbersInfo;
        }

        public bool Visible
        {
            get
            {
                return this.visible;
            }
            set
            {
                this.visible = value;
            }
        }
        public string Name
        {
            get
            {
                return this.titleName;
            }
        }
        public Image Icon
        {
            get
            {
                return this.icon;
            }
        }

        public void Draw(Graphics g)
        {
            if (visible)
            {
                //draw the background
                g.DrawImage(background, 0, 0);
                //draw the photo
                g.DrawImage(photo, 81, 111, 483 - 81, 512 - 111);
                //draw the title
                g.DrawString(titleName, titleNameFont, brush, new RectangleF(81, 68, 277 - 81, 98 - 68));
                //draw the text
                g.DrawString(textInfo, textInfoFont, brush, new RectangleF(83, 527, 675 - 83, 647 - 527));
                //draw the numbers
                g.DrawString(numbersInfo, numbersInfoFont, brush, new RectangleF(520, 111, 805 - 520, 512 - 111));
                //draw the icon
                g.DrawImage(icon, 687, 529, 805 - 687, 647 - 529);
            }
        }
    }
}
