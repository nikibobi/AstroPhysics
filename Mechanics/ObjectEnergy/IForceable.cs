using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics.ObjectEnergy
{
    interface IForceable
    {
        float Mass { get; set; }
        Vector Acceleration { get; set; }
    }
}
