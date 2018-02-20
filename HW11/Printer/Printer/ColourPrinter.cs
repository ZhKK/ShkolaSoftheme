using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class ColourPrinter : Printer
    {
        public ConsoleColor Color { get; set; }
        public ColourPrinter(string argum, ConsoleColor color)
            : base (argum)
        {
            Color = color;
        }
        public override void Print()
        {
            var message = string.Format("Colour Printer's argument is: ");
            Console.Write(message);
            Console.ForegroundColor = Color;
            Console.WriteLine(Argument);
            Console.ResetColor();
        }
    }
}