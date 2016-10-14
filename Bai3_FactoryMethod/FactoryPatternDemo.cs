using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_FactoryMethod
{
    class FactoryPatternDemo
    {
        static void Main(string[] args)
        {
            Shape circle = ShapeFactory.getShape("Circle");
            Shape square = ShapeFactory.getShape("Square");
            Shape rectangle = ShapeFactory.getShape("Rectangle");

            circle.draw();
            square.draw();
            rectangle.draw();

            Console.ReadKey();
        }
    }
}
