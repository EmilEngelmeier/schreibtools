using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Buntstift: Stift
    {
        public Buntstift(double lw, ConsoleColor cc) : base(lw, cc)
        {
            this.Art = "Buntstift";
        }
    }
}
