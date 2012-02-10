using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    public partial class SolarSystem : Form
    {
        //private Random random;
        private Univerce univerce;

        public SolarSystem()
        {
            InitializeComponent();
            //random = new Random();
            univerce = new Univerce(this);
            timer.Interval = 31;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            univerce.Tick();
            this.Refresh();
        }

        private void SolarSystem_Paint(object sender, PaintEventArgs e)
        {
            //this is for smooth lines
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            univerce.Draw(e.Graphics);
        }

        private void SolarSystem_Resize(object sender, EventArgs e)
        {
            univerce.SetAllBounds(this.Bounds);
        }

        private void SolarSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        #region context menu handlers
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(0f);
        }
        private void x05SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(0.5f);
        }
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(1.0f);
        }
        private void x20SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(2.0f);
        }
        private void x40SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(4.0f);
        }
        private void x160SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            univerce.ChangeSpeedModiffer(16.0f);
        }
        #endregion
    }
}
