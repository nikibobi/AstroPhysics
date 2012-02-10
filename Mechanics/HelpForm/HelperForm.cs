using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AstroPhysics.HelpForm
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();
        }

        private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
