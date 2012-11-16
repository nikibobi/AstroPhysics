using System.Windows.Forms;

namespace AstroPhysics.HelpForm
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();

            //axShockwaveFlash1.Movie = "http://www.youtube.com/v/2inpUb5eUbA";
            //axShockwaveFlash2.Movie = "http://www.youtube.com/v/8GLr2pod44Q";
            //axShockwaveFlash3.Movie = "http://www.youtube.com/v/d5p_uL4y-aY";
        }

        private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void backButton1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
