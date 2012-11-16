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
using AstroPhysics.Controls;

namespace AstroPhysics
{
    /// <summary>
    /// Класа за главното меню
    /// </summary>
    public partial class FormMenu : Form
    {
        /// <summary>
        /// Калкулатор на мерни единици форма
        /// </summary>
        Calculator calculatorForm;
        /// <summary>
        /// Механична енергия форма
        /// </summary>
        MechanicEnergy mechanicEnergyForm;
        /// <summary>
        /// Слънчевата система форма
        /// </summary>
        SolarSystem solarSystemForm;
        /// <summary>
        /// Помощ - форма
        /// </summary>
        HelperForm helperForm;

        /// <summary>
        /// Конструктора на главната форма инициализира останалите под-форми
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
            solarSystemForm = new SolarSystem();//this is here cause i CHEAT
        }

        /// <summary>
        /// Event-handler за бутона за калкулатор-формата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (calculatorForm == null)
                calculatorForm = new Calculator();
            calculatorForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Event-handler за бутона за форма механична енергия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (mechanicEnergyForm == null)
                mechanicEnergyForm = new MechanicEnergy();
            mechanicEnergyForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Event-handler за бутона за слънчевата система
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (solarSystemForm == null)
                solarSystemForm = new SolarSystem();
            solarSystemForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Event-handler за бутона за за помощната форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if(helperForm == null)
                helperForm = new HelperForm();
            helperForm.Show(this);
            this.Hide();
        }
    }
}
