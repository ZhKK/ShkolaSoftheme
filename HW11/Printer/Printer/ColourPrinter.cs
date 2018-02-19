using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class ColourPrinter : Printer
    {
        public byte Color { get; set; }
        public Printer(string argum, byte color)
        {
            Argument = argum;
            Color = color;
        }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.WriteLineColor(Argument);
            Console.ReadKey();
            base.Print;
        }

    }
}