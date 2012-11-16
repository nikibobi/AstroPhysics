using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Формата за Механична енергия
    /// </summary>
    public partial class MechanicEnergy : Form
    {
        private Graphics g;
        private Object physicalObject;
        private EnergyChart energyChart;
        private bool isMouseOverObject;
        private bool isDragging;
        private bool applyingForce;
        private Point mousePosition;
        private Pen forcePen;

        private ObjectProperties propertiesForm;

        /// <summary>
        /// Инициализира формата, физичния обект и евентите
        /// </summary>
        public MechanicEnergy()
        {
            InitializeComponent();

            physicalObject = new Object(Resources.Ball, Material.Gold, this.Width / 2, this.Height / 2, new Rectangle(0, 0, this.Width, 625))
            {
                Mass = 10,
                Speed = new Vector(0, 0),
                UseGravity = true
            };
            physicalObject.X = this.Width / 2;
            physicalObject.Y = 625;

            energyChart = new EnergyChart();

            this.MouseMove += MechanicEnergy_MouseMove;
            this.MouseWheel += MechanicEnergy_MouseWheel;
            this.MouseUp += MechanicEnergy_MouseUp;
            this.MouseDown += MechanicEnergy_MouseDown;

            forcePen = new Pen(Color.Black);
            forcePen.StartCap = LineCap.Round;
            forcePen.EndCap = LineCap.ArrowAnchor;

            propertiesForm = new ObjectProperties(physicalObject);

            timer.Start();
        }

        void MechanicEnergy_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMouseOverObject)
            {
                if (e.Button == MouseButtons.Right)
                {
                    isDragging = true;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    applyingForce = true;
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    physicalObject.Material = Material.GetRandom(new Random()); // changes the material to a random one
                }
            }
        }

        void MechanicEnergy_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isDragging = false;
            }
            if (e.Button == MouseButtons.Left && applyingForce)
            {
                applyingForce = false;
                float angle = (float)Math.Atan2(e.Y - physicalObject.Y, e.X - physicalObject.X);
                float value = (float)Convertor.GetDistance(e.Location, physicalObject.Location);
                physicalObject.AngleInRadians = angle;
                physicalObject.Force = new Force(value, angle);
            }
        }

        void MechanicEnergy_MouseWheel(object sender, MouseEventArgs e)
        {
            if (isMouseOverObject)
            {
                if (e.Delta > 0)
                {
                    physicalObject.Volume += 1;
                }
                else if (e.Delta < 0)
                {
                    physicalObject.Volume -= 1;
                }
            }
        }

        void MechanicEnergy_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;

            Rectangle mouseBox = new Rectangle(e.X, e.Y, 1, 1);
            Rectangle objectBox = physicalObject.ClickBox;
            if (objectBox.IntersectsWith(mouseBox))
            {
                isMouseOverObject = true;
            }
            else
            {
                isMouseOverObject = false;
            }

            if (isDragging)
            {
                physicalObject.Force = new Force();
                physicalObject.AngleInRadians = 0;

                physicalObject.X = e.X;
                physicalObject.Y = e.Y;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            propertiesForm.Controls["textBoxKineticEnergy"].Text = physicalObject.KineticEnergy.ToString();
            propertiesForm.Controls["textBoxPotentialEnergy"].Text = physicalObject.PotentialEnergy.ToString();
            propertiesForm.Controls["textBoxMechanicEnergy"].Text = physicalObject.MechanicEnergy.ToString();

            ((NumericUpDown)propertiesForm.Controls["numericUpDownVolume"]).Value = (decimal)physicalObject.Volume;
            ((NumericUpDown)propertiesForm.Controls["numericUpDownMass"]).Value = (decimal)physicalObject.Mass;
            propertiesForm.Controls["textBoxSpeed"].Text = physicalObject.Speed.Value.ToString();
            propertiesForm.Controls["textBoxForce"].Text = physicalObject.Force.Value.ToString();

            energyChart.addSeriesValues(physicalObject.KineticEnergy, physicalObject.PotentialEnergy, physicalObject.MechanicEnergy);

            physicalObject.Tick();

            if (applyingForce)
            {
                forcePen.Width = 16 + (float)Convertor.GetDistance(physicalObject.Location, mousePosition) * 0.03f;
            }

            this.Refresh();
        }

        private void MechanicEnergy_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            physicalObject.Draw(g);
            if (applyingForce)
            {
                g.DrawLine(forcePen, physicalObject.Location, mousePosition);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!propertiesForm.Visible)
            {
                propertiesForm.Show(this);
            }
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (!energyChart.Visible)
            {
                energyChart.Show(this);
            }
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            energyChart.Hide();
            propertiesForm.Hide();
            this.Owner.Show();
        }

        private void MechanicEnergy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
