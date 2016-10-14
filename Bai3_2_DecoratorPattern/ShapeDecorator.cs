using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2_DecoratorPattern
{
    abstract class ShapeDecorator : Shape
    {
        protected Shape shape;

        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }

         public void draw()
        {
            shape.draw();
            setBorderColor();
        }
        public abstract void setBorderColor();

    }
}
