using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_FactoryMethod
{
    class ShapeFactory
    {
        public static Shape getShape(string shapeType)
        {
            if (shapeType == "Circle")
                return new Circle();
            else
                if (shapeType.Equals("Rectangle"))
                return new Rectangle();
            else
                return new Square();
        }
    }
}
