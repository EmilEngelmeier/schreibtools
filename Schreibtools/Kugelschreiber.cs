using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Kugelschreiber: Stift
    {
        public Kugelschreiber(double lw, ConsoleColor cc) : base(lw, cc)
        {
            this.Art = "Kulli";
        }
    }
}
