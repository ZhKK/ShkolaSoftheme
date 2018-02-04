using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Press Esc to exit");
            do
            {
                try
                {
                    Console.WriteLine("Enter 1st number:");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter an operator:");
                    char oprt = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter 2nd number:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("_______________");
                    Console.WriteLine("Result:");

                    double rez = 0;
                    if (oprt == '+')
                    {
                        rez = a + b;
                        Console.WriteLine(a + " + " + b + " = " + "{0:##.##}", rez);
                    }
                
                    if (oprt == '-')
                        Console.WriteLine(a + " - " + b + " = " + "{0:##.##}", (a - b));
                    if (oprt == '*')
                        Console.WriteLine(a + " * " + b + " = " + "{0:##.##}", (a * b));
                    if (oprt == '/')
                    {
                        rez = a / b;
                        Console.WriteLine(a + " / " + b + " = " + "{0:##.##}", rez);
                    }
                    Console.WriteLine();
                }
                    catch (DivideByZeroException) {
                        Console.WriteLine("Сan not be divided by zero!");
                    }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
