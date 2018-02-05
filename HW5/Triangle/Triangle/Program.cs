using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" To draw a shape, enter the key: t - triangle, s - square: ");
            char fig = char.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine(" Enter a length of sides: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        
            /*private void ShowTriangle(object sender, RoutedEventArgs e)
            {
                
                do
                {
                    int nextDigit = amount % 8;
                    amount /= 8;
                    int digitCode = '0' + nextDigit;
                    char digit = Convert.ToChar(digitCode);
                    current = digit + current;
                    steps.Text += current + "\n";
                }
                while (amount != 0);
            }*/
        }
    }
}
