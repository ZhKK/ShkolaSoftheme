using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("toyota celica", 1977, "blue");
            Car Car2 = new Car("porsche panamera", 2017, "brown");
            Car Car3 = new Car("tesla model s", 2017, "black");

            Console.WriteLine("Cars:");

            Car1.WriteInfo(Car1._model, Car1._year, Car1._color);
            TuningAtelier.TuneCar(Car1);
            Console.WriteLine("new color: {0}", Car1._color);

            Car2.WriteInfo(Car2._model, Car2._year, Car2._color);
            TuningAtelier.TuneCar(Car2);
            Console.WriteLine("new color: {0}", Car2._color);

            Car3.WriteInfo(Car3._model, Car3._year, Car3._color);
            TuningAtelier.TuneCar(Car3);
            Console.WriteLine("new color: {0}", Car3._color);

            Console.ReadKey();
        }
    }
}