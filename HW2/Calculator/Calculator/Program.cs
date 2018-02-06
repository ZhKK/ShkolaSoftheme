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
            Console.WriteLine("Press Esc to exit.");
            do
            {
                try
                {
                    double a, b;
                    char oprt;
                    MethodInPut(out a, out oprt, out b);

                    double rez = 0;
                    MethodSum(a, oprt, b, rez);
                    MethodMinus(a, oprt, b);
                    MethodMultipl(a, oprt, b);

                    rez = MethodDivid(a, oprt, b, rez);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter less numbers!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Use the correct input formats!");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static void MethodInPut(out double a, out char oprt, out double b)
        {
            Console.WriteLine("Enter 1st number:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator:");
            oprt = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("_______________");
            Console.WriteLine("Result:");
        }

        private static double MethodDivid(double a, char oprt, double b, double rez)
        {
            if (oprt == '/')
            {
                try
                {
                    rez = a / b;
                    Console.WriteLine(a + " / " + b + " = " + "{0:##.##}", rez);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Сan not be divided by zero!");
                }
                finally
                {
                    Console.WriteLine("Сan not be divided by zero!");
                }
            }

            return rez;
        }

        private static void MethodMultipl(double a, char oprt, double b)
        {
            if (oprt == '*')
            {
                Console.WriteLine(a + " * " + b + " = " + "{0:##.##}", (a * b));
            }
        }

        private static void MethodMinus(double a, char oprt, double b)
        {
            if (oprt == '-')
            {
                Console.WriteLine(a + " - " + b + " = " + "{0:##.##}", (a - b));
            }
        }

        private static void MethodSum(double a, char oprt, double b, double rez)
        {
            if (oprt == '+')
            {
                rez = a + b;
                Console.WriteLine(a + " + " + b + " = " + "{0:##.##}", rez);
            }
        }
    }
}
