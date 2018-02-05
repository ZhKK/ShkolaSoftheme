using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For exit enter Esc.");
            do
            {
                Console.WriteLine("Enter your birth date like DD/MM/YYYY:");
                string []date = Console.ReadLine().Split('/');
                Console.WriteLine(date);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
