using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Canon Printer Printing....");
        }
    }
}
