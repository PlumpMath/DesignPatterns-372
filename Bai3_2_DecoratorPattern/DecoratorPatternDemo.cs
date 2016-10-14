using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2_DecoratorPattern
{
    class DecoratorPatternDemo
    {
        static void Main(string[] args)
        {
            Shape circle = new RedShapeDecorator(new Circle());
            
            circle.draw();
            circle = new RedShapeDecorator(circle);
            Console.WriteLine();
            circle.draw();


            //Shape rectangle = new Rectangle();
            //Shape redRectangle = new RedShapeDecorator(rectangle);




            //circle.draw();
            //Console.WriteLine("---------Decorator---------");
            //redCircle.draw();
            //Console.WriteLine();
            //rectangle.draw();
            //Console.WriteLine("---------Decorator---------");
            //redRectangle.draw();

            Console.ReadKey();
        }
    }
}
