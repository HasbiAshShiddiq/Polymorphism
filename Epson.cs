using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson Printer Printing....");
        }
    }
}
