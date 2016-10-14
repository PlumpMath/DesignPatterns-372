using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Triangle : Shape
    {
        
        public override void NhapThamSo()
        {
            Console.Write("Nhap chieu cao: ");
            double temp;
            double.TryParse(Console.ReadLine().ToString(), out temp);
            para.Add(temp);
            Console.Write("Nhap do dai day: ");

            double.TryParse(Console.ReadLine().ToString(), out temp);
            para.Add(temp);

        }

   

        protected override double Tinh()
        {
            return 0.5 * (double) para[0] * (double) para[1];
           
        }

        
    }
}
