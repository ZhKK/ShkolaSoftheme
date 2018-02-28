using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = null;
            Console.WriteLine("q: Exit");

            while (true)
            {
                int length = 0;
                int len = 0;
                Console.WriteLine("Enter the number of elements in the array: ");

                    len = int.Parse(Console.ReadLine());
                try
                {
                    length = len;
                    if(length < 0)
                    {
                        throw new Exception("The number of elements in the array can not be less than zero.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return;
                }
                  
                    int[] array = new int[length];
               

                int arrayMin = -100;
                int arrayMax = 100;

                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(arrayMin, arrayMax);
                }

                Console.Write("Array: ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }

                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0)
                    {
                        sum += array[i];
                    }

                Console.WriteLine("\n\nThe sum of the positive elements of the array: " + sum.ToString());
                key = Console.ReadLine();
                if (key == "q")
                {
                    break;
                }
            }
        }
    }
}