using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AstroPhysics.ValueCalculator
{
    //I think im done here ... 
    //the only thing I can do is add more Units
    public partial class Calculator : Form
    {
        private const string FORMAT_THOUSENDS = "#,0.########################################";
        private const string FORMAT_NOTHOUSENDS = "#0.########################################";
        private Stats stats;
        private Dictionary<Units, TextBox> textBoxes;
        private Units currentUnit;
        private string thousendsFormat;
        private Dictionary<string, Label> labels;

        public Calculator()
        {
            InitializeComponent();
            stats = new Stats();
            textBoxes = new Dictionary<Units, TextBox>();
            labels = new Dictionary<string, Label>();
            addTextBoxes();
            addLabels();
            changeTextboxTextChanged(true);
            thousendsFormat = FORMAT_NOTHOUSENDS;
            comboBoxValue.SelectedIndex = 0;

            foreach (Units unit in UnitS.Array)
            {
                textBoxes[unit].KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            }
        }

        void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void addLabels()
        {
            labels.Add("n", labelNano);
            labels.Add("μ", labelMicro);
            labels.Add("m", labelMilli);
            labels.Add("c", labelCenti);
            labels.Add("d", labelDeci);
            labels.Add("", labelNormal);
            labels.Add("da", labelDeca);
            labels.Add("h", labelHecto);
            labels.Add("k", labelKilo);
            labels.Add("M", labelMega);
            labels.Add("G", labelGiga);
        }

        // here is the place to add more textboxes and units
        private void addTextBoxes()
        {
            textBoxes.Add(Units.Nano, textBoxNano);
            textBoxes.Add(Units.Micro, textBoxMicro);
            textBoxes.Add(Units.Milli, textBoxMili);
            textBoxes.Add(Units.Centi, textBoxCenti);
            textBoxes.Add(Units.Deci, textBoxDeci);
            textBoxes.Add(Units.Normal, textBoxNormal);
            textBoxes.Add(Units.Deca, textBoxDeca);
            textBoxes.Add(Units.Hecto, textBoxHecto);
            textBoxes.Add(Units.Kilo, textBoxKilo);
            textBoxes.Add(Units.Mega, textBoxMega);
            textBoxes.Add(Units.Giga, textBoxGiga);
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        //only updates the text in the textboxes
        private void updateTextboxes()
        {
            changeTextboxTextChanged(false);
            foreach (Units unit in UnitS.Array)
            {
                textBoxes[unit].Text = stats.GetStat(unit).ToString(thousendsFormat);
            }
            changeTextboxTextChanged(true);
        }

        //enables/disables input event handler
        private void changeTextboxTextChanged(bool enable)
        {
            if (enable)
            {
                foreach (Units unit in UnitS.Array)
                {
                    textBoxes[unit].TextChanged += textBoxAll_TextChanged;
                }
            }
            else
            {
                foreach (Units unit in UnitS.Array)
                {
                    textBoxes[unit].TextChanged -= textBoxAll_TextChanged;
                }
            }
        }

        // handles the input for all the textboxes
        private void textBoxAll_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = null;
            if (sender is TextBox)
            {
                textBox = sender as TextBox;
            }
            else
            {
                return;
            }

            try
            {
                stats.SetStat(currentUnit, double.Parse(textBox.Text));
            }
            catch (FormatException)
            {
                stats.SetStat(Units.Normal, 0);
                //MessageBox.Show("Въвведеното не е число \n Моля въведете число", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread(); // optional <<
            }
            updateTextboxes();
        }

        //If i add more units add more handlers here too
        #region Event handlers for textBoxes
        private void textBoxNano_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Nano;
        }
        private void textBoxMicro_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Micro;
        }
        private void textBoxMili_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Milli;
        }
        private void textBoxCenti_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Centi;
        }
        private void textBoxDeci_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Deci;
        }
        private void textBoxNormal_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Normal;
        }
        private void textBoxDeca_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Deca;
        }

        private void textBoxHecto_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Hecto;
        }
        private void textBoxKilo_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Kilo;
        }
        private void textBoxMega_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Mega;
        }
        private void textBoxGiga_TextChanged(object sender, EventArgs e)
        {
            currentUnit = Units.Giga;
        }
        #endregion

        // enables/disables thousends separator
        private void checkBoxThousends_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                thousendsFormat = FORMAT_THOUSENDS;
            else
                thousendsFormat = FORMAT_NOTHOUSENDS;
            updateTextboxes();
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Label> pair in labels)
            {
                pair.Value.Text = pair.Key + comboBoxValue.SelectedItem.ToString();
            }
        }
    }
}
