using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OOP
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Battery b = new Battery("Lio",5);
             Laptop laptop = new Laptop("Lenovo Z540", "Lenovo", "i7 4Ghz",
                 "8", "Ati Radeon", "600", "17''", 1400,
                 "Li-Ion, 4-cells, 2550 mAh", 4.5);

             Console.WriteLine(laptop.ToString());
        }
    }
}
