using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_FactoryMethod
{
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Method: Draw a Circle!");
        }
    }
}
