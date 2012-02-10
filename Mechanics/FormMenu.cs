using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroPhysics.ValueCalculator;
using AstroPhysics.ObjectEnergy;
using AstroPhysics.Astronomy;
using AstroPhysics.HelpForm;

namespace AstroPhysics
{
    public partial class FormMenu : Form
    {
        Calculator calculatorForm;
        MechanicEnergy mechanicEnergyForm;
        SolarSystem solarSystemForm;
        HelperForm helperForm;

        public FormMenu()
        {
            InitializeComponent();
            calculatorForm = new Calculator();
            mechanicEnergyForm = new MechanicEnergy();
            solarSystemForm = new SolarSystem();
            helperForm = new HelperForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatorForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mechanicEnergyForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solarSystemForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helperForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorForm.Dispose();
            mechanicEnergyForm.Dispose();
            solarSystemForm.Dispose();
            helperForm.Dispose();
            Application.Exit();
        }
    }
}
