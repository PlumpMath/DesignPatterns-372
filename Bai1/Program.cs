using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle();
            triangle.NhapThamSo();
            triangle.hienThiKetQua += HienThiTheo_Inches;
            triangle.TinhDienTich();


           // Shape rectangle = new Rectangle();
           // rectangle.NhapThamSo();
           //rectangle.hienThiKetQua += HienThiTheo_Met;
           // rectangle.TinhDienTich();

            Console.ReadKey();
        }

        static void HienThiTheo_Inches(double x)
        {
            Console.WriteLine("Dien tich theo don vi Inches là: {0}", x / 2.5);
        }
        static void HienThiTheo_Met(double x)
        {
            Console.WriteLine("Dien tich theo don vi Met là: {0}", x);
        }
    }
}
