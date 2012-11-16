using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AstroPhysics.Controls;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    public partial class SolarSystem : Form
    {
        private const int InitalTimerInterval = 31;

        //private Univerce univerce;
        private DateCounter counter;
        private World world;

        public SolarSystem()
        {
            InitializeComponent();
            Input.Mouse.Initialize(this);//init input
            world = new World(PlanetFactory.Tree);
            world.Bounds = Bounds;
            counter = new DateCounter(new TimeSpan(0, 23, 30, 0), world);
            counter.DateChanged += counter_DateChanged;
            timer.Interval = InitalTimerInterval;
            timer.Start();
        }

        private void counter_DateChanged(object sender, EventArgs e)
        {
            dateTimePicker.Value = counter.Date;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            world.Tick();
            counter.Tick();
            dateTimePicker.Visible = Math.Abs(world.SpeedModiffer - 0) < 0.00000001; //if this is near 0 show stuff

            Refresh();
        }

        private void SolarSystem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //this is for smooth lines
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(Resources.Space, Screen.PrimaryScreen.WorkingArea);
            counter.Draw(g);
            world.Draw(g);
        }

        private void SolarSystem_Resize(object sender, EventArgs e)
        {
            world.Bounds = Bounds;
        }

        //TODO: total bullshit change later
        private void SolarSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        #region context menu handlers
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(0f);
        }
        private void x05SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(0.5f);
        }
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(1f);
        }
        private void x20SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(2f);
        }
        private void x40SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(4f);
        }
        private void x160SpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(16f);
        }
        private void x1СкоростToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSimulationSpeed(-1);
        }
        #endregion

        private void ChangeSimulationSpeed(float multiplyer)
        {
            world.SpeedModiffer = multiplyer;
            counter.SpeedModiffer = multiplyer;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            counter.Date = dateTimePicker.Value;
            timer.Start();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
