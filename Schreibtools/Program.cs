using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtools
{
    class Program
    {
        static List<Stift> stifte;
        static void Main(string[] args)
        {
            stifte = new List<Stift>();

            stifte.Add(new Kugelschreiber(3.0, ConsoleColor.Cyan));
            stifte.Add(new Kugelschreiber(3.0, ConsoleColor.Yellow));
            stifte.Add(new Buntstift(3.0, ConsoleColor.Green));
            stifte.Add(new Buntstift(3.0, ConsoleColor.DarkGray));

            foreach (var item in stifte)
            {
                item.WriteText("Hallo 3CHIT");
            }


            Console.ReadKey();

        }
    }
}
