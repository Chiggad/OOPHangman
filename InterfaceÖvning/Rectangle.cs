using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖvning
{
    internal class Rectangle : IShape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public Rectangle(double rectangleBase, double rectangleHeight)
        {
            Base = rectangleBase;
            Height = rectangleHeight;
        }

        public double GetArea()
        {
            double rectangleArea = Base * Height;
            Console.WriteLine($"Rectangle area is: {rectangleArea}");
            return rectangleArea;
        }

        public double GetPerimeter()
        {
            double rectanglePerimeter = (2 * Base) + (2 * Height);
            Console.WriteLine($"Rectangle perimeter is: {rectanglePerimeter}");
            return rectanglePerimeter;
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}