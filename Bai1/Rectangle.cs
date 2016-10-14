using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Rectangle : Shape

    {



        public override void NhapThamSo()
        {
            Console.Write("Nhap chieu dai: ");
            double a;
            double.TryParse(Console.ReadLine().ToString(), out a);
            para.Add(a);
            Console.Write("Nhap chieu rong: ");
            double b;
            double.TryParse(Console.ReadLine().ToString(), out b);
            para.Add(b);
        }


        protected override double Tinh()
        {
            return  (double) para[0] * (double)para[1];

        }
    }
}
