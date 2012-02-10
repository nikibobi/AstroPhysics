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

namespace AstroPhysics.ObjectEnergy
{
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

        public MechanicEnergy()
        {
            InitializeComponent();
            physicalObject = new Object(Resources.Ball, Material.Gold, this.Width / 2, this.Height / 2, new Rectangle(0, 0, this.Width, 625))
            {
                Material = Material.Iron,
                Mass = (float)numericUpDownMass.Value,
                Speed = new Vector((float)numericUpDownSpeed.Value, 0)
            };
            physicalObject.X = this.Width / 2;
            physicalObject.Y = 625;
            comboBox1.SelectedIndex = 0;

            energyChart = new EnergyChart();

            this.MouseMove += MechanicEnergy_MouseMove;
            this.MouseWheel += MechanicEnergy_MouseWheel;
            this.MouseUp += MechanicEnergy_MouseUp;
            this.MouseDown += MechanicEnergy_MouseDown;

            forcePen = new Pen(Color.Black);
            forcePen.StartCap = LineCap.Round;
            forcePen.EndCap = LineCap.ArrowAnchor;

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
                physicalObject.Force = new Vector(value, angle);
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
                physicalObject.Force = new Vector();
                physicalObject.AngleInRadians = 0;

                physicalObject.X = e.X;
                physicalObject.Y = e.Y;
            }
        }

        private void MechanicEnergy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            energyChart.Hide();
            e.Cancel = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxKineticEnergy.Text = physicalObject.KineticEnergy.ToString() + " J";
            textBoxPotentialEnergy.Text = physicalObject.PotentialEnergy.ToString() + " J";
            textBoxMechanicEnergy.Text = (physicalObject.MechanicEnergy).ToString() + " J";

            numericUpDownVolume.Value = (decimal)physicalObject.Volume;
            numericUpDownMass.Value = (decimal)physicalObject.Mass;
            numericUpDownSpeed.Value = (decimal)physicalObject.Speed.Value;

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

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            physicalObject.Speed = new Vector((float)numericUpDownSpeed.Value, physicalObject.AngleInRadians);
        }

        private void numericUpDownMass_ValueChanged(object sender, EventArgs e)
        {
            physicalObject.Mass = (float)numericUpDownMass.Value;
        }

        private void numericUpDownVolume_ValueChanged(object sender, EventArgs e)
        {
            physicalObject.Volume = (float)numericUpDownVolume.Value;
        }

        private void buttonEnergyChart_Click(object sender, EventArgs e)
        {
            energyChart.Show();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            groupBox.Visible = true;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            groupBox.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                physicalObject.Material = Material.Gold;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                physicalObject.Material = Material.Iron;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                physicalObject.Material = Material.Copper;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                physicalObject.Material = Material.Silver;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                physicalObject.Material = Material.Lead;
            }
            else
            {
                MessageBox.Show("NOT Found");
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (groupBox.Visible)
            {
                buttonApply.Text = "Свойства";
                groupBox.Visible = false;
                timer.Start();
            }
            else
            {
                buttonApply.Text = "Приложи";
                groupBox.Visible = true;
                timer.Stop();
            }
        }
    }
}
