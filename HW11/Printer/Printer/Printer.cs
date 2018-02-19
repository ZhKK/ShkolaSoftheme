using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Printer
    {
        public string Argument { get; set; }

        public Printer(string argum)
        {
            Argument = argum;
        }
        public virtual void Print()
        {
            var message = string.Format("Printer's argument is: {0}", Argument);
            Console.WriteLine(message);
        }
    }
}