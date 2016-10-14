using System;

namespace Bai3_3_FacadePattern
{
    class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();

            Console.ReadKey();
        }
    }
}
