using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.Controls
{
    class PlayButtonEventArgs : EventArgs
    {
        public PlayButtonEventArgs(bool playing)
        {
            this.Playing = playing;
        }

        public bool Playing { get; set; }
    }
}
