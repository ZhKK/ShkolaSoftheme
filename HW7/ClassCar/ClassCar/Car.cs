using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar
{
    public class Car
    {
        public string _model { get; private set; }
        public int _year {get; private set; }
        public string _color { get; set; }

        public Car (string model, int year, string color)
        {
            _model = model;
            _year = year;
            _color = color;
        }

        public void WriteInfo (string m, int y, string c)
        {
            Console.WriteLine("\n{0} ({1})\n{2}", m, y, c);
        }
    }
}