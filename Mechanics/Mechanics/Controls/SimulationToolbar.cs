using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.Controls
{
    public partial class SimulationToolbar : UserControl
    {
        private const int MIN_Y = -30;
        private const int MAX_Y = 30;

        private bool hidden;
        private bool playing;
        private Image playImage;
        private Image pauseImage;

        public event EventHandler PlayButtonClicked;

        public SimulationToolbar()
        {
            InitializeComponent();

            playImage = Resources.play;
            pauseImage = Resources.pause;
            Playing = true;
            hidden = true;
        }

        private bool Playing
        {
            get
            {
                return this.playing;
            }
            set
            {
                if (value)
                {
                    play.Image = pauseImage;
                }
                else
                {
                    play.Image = playImage;
                }
                this.playing = value;
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            Playing = !Playing;
            OnPlayButtonClicked();
        }

        protected void OnPlayButtonClicked()
        {
            EventHandler playButtonClicked = this.PlayButtonClicked;
            if (playButtonClicked != null)
            {
                PlayButtonEventArgs e = new PlayButtonEventArgs(Playing);
                playButtonClicked(this, e);
            }
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            if (!hidden)
            {
                int yControlls = 0;
                int i = 1;
                do
                {
                    foreach (Control control in Controls)
                    {
                        var x = control.Location.X;
                        var y = control.Location.Y;
                        control.Location = new Point(x, y - i);
                    }
                    yControlls -= i;
                } while (yControlls > MIN_Y);
                hidden = true;
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            if (hidden)
            {
                int yControlls = 0;
                int i = 1;
                do
                {
                    foreach (Control control in Controls)
                    {
                        var x = control.Location.X;
                        var y = control.Location.Y;
                        control.Location = new Point(x, y + i);
                    }
                    yControlls += i;
                } while (yControlls < MAX_Y);
                hidden = false;
            }
        }
    }
}
