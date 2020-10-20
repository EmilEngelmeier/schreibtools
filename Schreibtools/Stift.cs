using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Stift
    {
        public double Breite { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Art { get; set; }

        public Stift(double lw)
        {
            Breite = lw;
            Art = "unknown";
            Farbe = ConsoleColor.Black;
        }

        public Stift(double lw, ConsoleColor f) : this(lw)
        {
            Farbe = f;
        }

        public void WriteText(string text)
        {
            Console.ForegroundColor = this.Farbe;
            Console.WriteLine($"({this.Art},{this.Breite}mm,{this.Farbe}){text}");
            Console.ResetColor();
        }
    }
}
