using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.Controls
{
    public partial class ScrollBar : UserControl
    {
        private double value;
        private Image handleImage;
        private Point handlePos;
        private Size handleSize;
        private Image background;

        public ScrollBar()
        {
            InitializeComponent();
            DoubleBuffered = true;
            handle.Size = new Size(Height, Height);
            handleImage = handle.Image;
            handlePos = handle.Location;
            handleSize = new Size(Height, Height);
            background = Resources.Space;
        }

        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public Image HandleImage
        {
            get
            {
                return this.handleImage;
            }
            set
            {
                this.handleImage = value;
            }
        }

        private Point HandlePos
        {
            get
            {
                return this.handlePos;
            }
            set
            {
                this.handlePos = value;
                if (handlePos.X < 0)
                {
                    handlePos = new Point(0, handlePos.Y);
                }
                else if ((handlePos + new Size(handleSize.Width, 0)).X > this.Width)
                {
                    handlePos = new Point(Width - handleSize.Width, handlePos.Y);
                }
            }
        }

        private void ScrollBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(background, new Rectangle(0, 0, Width, Height));
            g.DrawImage(HandleImage, new Rectangle(HandlePos, handleSize));
        }

        private void ScrollBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseAction(e);
        }

        private void ScrollBar_MouseMove(object sender, MouseEventArgs e)
        {
            mouseAction(e);
        }

        private void mouseAction(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HandlePos = new Point(e.Location.X - handleSize.Width / 2, HandlePos.Y);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
