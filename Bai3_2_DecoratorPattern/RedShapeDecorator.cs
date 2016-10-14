using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2_DecoratorPattern
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape)
            : base(shape) { }

        public override void setBorderColor()
        {
            //Border Color: Red
            Console.WriteLine("with border color: Red");
        }
    }

    
}
