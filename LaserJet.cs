using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display Dimension : 12*12");
        }
        public override void print()
        {
            Console.WriteLine("LaserJet Printer Printing....");
        }
    }
}
