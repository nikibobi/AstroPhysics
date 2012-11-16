using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AstroPhysics.ObjectEnergy
{
    partial class ObjectProperties : Form
    {
        private Object physicalObject;
        public ObjectProperties(Object physicalObjcet)
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.MouseEnter += ObjectProperties_MouseEnter;
            }
            this.physicalObject = physicalObjcet;
            comboBox1.SelectedIndex = 0;
        }

        private void ObjectProperties_MouseEnter(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void ObjectProperties_MouseLeave(object sender, EventArgs e)
        {
            Opacity = 0.6;
        }

        private void ObjectProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
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

        private void numericUpDownVolume_ValueChanged(object sender, EventArgs e)
        {
            physicalObject.Volume = (float)numericUpDownVolume.Value;
        }

        private void numericUpDownMass_ValueChanged(object sender, EventArgs e)
        {
            physicalObject.Mass = (float)numericUpDownMass.Value;
        }
    }
}
