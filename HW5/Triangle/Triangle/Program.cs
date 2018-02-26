using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        private static int InputLength()
        {
            int length;

            Console.Write("Input length: ");

            try
            {
                length = int.Parse(Console.ReadLine());

                if ((length < 1) || (length > 10))
                    throw new Exception("The parameter value is outside the range");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }

            return length;
        }

        private static void PrintTriangle()
        {
            int length;
            int row, col;

            if ((length = InputLength()) < 0)
                return;

            Console.WriteLine("");

            for (row = 0; row < length; row++)
            {
                for (col = 0; col < (row + 1); col++)
                    Console.Write("* ");
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        private static void PrintSquare()
        {
            int length;
            int row, col;

            if ((length = InputLength()) < 0)
                return;

            Console.WriteLine("");

            for (row = 0; row < length; row++)
            {
                for (col = 0; col < length; col++)
                    Console.Write("* ");
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        private static void PrintRomb()
        {
            int length;
            int row, col;

            if ((length = InputLength()) < 0)
                return;

            Console.WriteLine("");

            ///////////////////////////////////////////////////
            // Draw hi part
            for (row = 0; row < length; row++)
            {
                // Draw blank
                for (col = 0; col < (length - row - 1); col++)
                    Console.Write("  ");

                // Draw *
                for (col = 0; col < (row * 2) + 1; col++)
                    Console.Write("* ");

                Console.WriteLine("");
            }

            ///////////////////////////////////////////////////
            // Draw low part
            for (row = 0; row < length - 1; row++)
            {
                // Draw blank
                for (col = 0; col < (row + 1); col++)
                    Console.Write("  ");

                // Draw *
                for (col = 0; col < ((length - row - 2) * 2) + 1; col++)
                    Console.Write("* ");

                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Triangle");
            Console.WriteLine("2: Square");
            Console.WriteLine("3: Romb");
            Console.WriteLine("q: Exit");
        }

        public static void Main(string[] args)
        {
            string key;

            while (true)
            {
                    PrintMenu();

                    key = Console.ReadLine();

                    if (key == "1")
                        PrintTriangle();
                    else if (key == "2")
                        PrintSquare();
                    else if (key == "3")
                        PrintRomb();
                    else if (key == "q")
                        break;
            }
        }
    }
}