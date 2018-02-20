using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class PhotoPrinter : Printer
    {
        public string Path { get; set; }
        public PhotoPrinter(string argum, string path)
            : base (argum)
        {
            Argument = null;
            Path = path;
        }
        public override void Print()
        {
            //method for printing img
            var message = string.Format("Photo Printer is printing... :)");
            Console.WriteLine(message);
        }
    }
}