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
            for (; ; )
            {
                Console.WriteLine("Press Esc to exit");
                do
                {
                    Console.WriteLine("Введите первое число:");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите оператор:");
                    char oprt = char.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("_______________");
                    Console.WriteLine("Результат:");

                    if (oprt == '+')
                        Console.WriteLine(a + " + " + b + " = " + "{0:##.##}", (a + b));
                    if (oprt == '-')
                        Console.WriteLine(a + " - " + b + " = " + "{0:##.##}", (a - b));
                    if (oprt == '*')
                        Console.WriteLine(a + " * " + b + " = " + "{0:##.##}", (a * b));
                    if (oprt == '/')
                        Console.WriteLine(a + " / " + b + " = " + "{0:##.##}", (a / b));
                    Console.WriteLine();
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape); break;

            }
        }
    }
}
