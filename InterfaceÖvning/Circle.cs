using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖvning
{
    internal class Circle : IShape
    {
        public double Radie { get; set; }

        public Circle(double radius)
        {
            Radie = radius;
        }

        public double GetArea()
        {
            double circleArea = Math.PI * Radie * Radie;
            Console.WriteLine($"Circles Area is: {circleArea} ");
            return circleArea;
        }

        public double GetPerimeter()
        {
            double circlePerimeter = 2 * Math.PI * Radie;
            Console.WriteLine($"Circles perimeter is: {circlePerimeter}");
            return circlePerimeter;
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}