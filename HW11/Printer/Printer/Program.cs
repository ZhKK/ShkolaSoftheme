using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {

        static void Main(string[] args)
        {
            Printer printer = new Printer("stone");
            printer.Print();

            ColourPrinter printer1 = new ColourPrinter("flame", ConsoleColor.Red);
            printer1.Print();

            PhotoPrinter printer2 = new PhotoPrinter("", "c://img1.jpeg");
            printer2.Print();

            Console.ReadKey();
        }
    }
}
